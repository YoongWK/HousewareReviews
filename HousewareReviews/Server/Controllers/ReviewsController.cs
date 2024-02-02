using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HousewareReviews.Shared.Domain;
using HousewareReviews.Server.IRepository;

namespace HousewareReviews.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        // Define the IUnitOfWork instance
        private readonly IUnitOfWork _unitOfWork;

        // Constructor that takes the IUnitOfWork instance
        public ReviewsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Reviews
        // Action method to retrieve all reviews
        [HttpGet]
        public async Task<IActionResult> GetReviews()
        {
            var reviews = await _unitOfWork.Reviews.GetAll(includes: q => q.Include(x => x.Product).Include(x => x.Consumer));
            return Ok(reviews);
        }

        // GET: api/Reviews/5
        // Action method to retrieve a specific review by id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetReview(int id)
        {
            var review = await _unitOfWork.Reviews.Get(q => q.Id == id, includes: q => q.Include(x => x.Product).Include(x => x.Consumer));

            // Check if review is not found
            if (review == null)
            {
                return NotFound();
            }

            return Ok(review);
        }

        // PUT: api/Reviews/5
        // Action method to update an existing review
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReview(int id, Review review)
        {
            // Check if the provided id matches the review's id
            if (id != review.Id)
            {
                return BadRequest();
            }

            // Update the review in the repository
            _unitOfWork.Reviews.Update(review);

            try
            {
                // Save changes to the database
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // If the review doesn't exist
                if (!await ReviewExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Reviews
        // Action method to create a new review
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Review>> PostReview(Review review)
        {
            // Insert the new review into the repository
            await _unitOfWork.Reviews.Insert(review);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetReview", new { id = review.Id }, review);
        }

        // DELETE: api/Reviews/5
        // Action method to delete a review by id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            // Retrieve the review by id
            var review = await _unitOfWork.Reviews.Get(q => q.Id == id);

            // If the review doesn't exist
            if (review == null)
            {
                return NotFound();
            }

            // Delete the review from the repository
            await _unitOfWork.Reviews.Delete(id);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // Private method to check if review with a given id exists
        private async Task<bool> ReviewExists(int id)
        {
            var review = await _unitOfWork.Reviews.Get(q => q.Id == id);
            return review != null;
        }
    }
}

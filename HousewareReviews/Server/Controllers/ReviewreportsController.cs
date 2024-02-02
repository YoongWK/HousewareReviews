using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HousewareReviews.Shared.Domain;
using HousewareReviews.Server.IRepository;

namespace HousewareReviews.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewreportsController : ControllerBase
    {
        // Define the IUnitOfWork instance
        private readonly IUnitOfWork _unitOfWork;

        // Constructor that takes the IUnitOfWork instance
        public ReviewreportsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Reviewreports
        // Action method to retrieve all reviewreports
        [HttpGet]
        public async Task<ActionResult> GetReviewreports()
        {
            var reviewreports = await _unitOfWork.Reviewreports.GetAll(includes: q => q.Include(x => x.Review).Include(x => x.Consumer).Include(x => x.Staff));
            return Ok(reviewreports);
        }

        // GET: api/Reviewreports/5
        // Action method to retrieve a specific reviewreport by id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetReviewreport(int id)
        {
            var reviewreport = await _unitOfWork.Reviewreports.Get(q => q.Id == id, includes: q => q.Include(x => x.Review).Include(x => x.Consumer).Include(x => x.Staff));

            // Check if reviewreport is not found
            if (reviewreport == null)
            {
                return NotFound();
            }

            return Ok(reviewreport);
        }

        // PUT: api/Reviewreports/5
        // Action method to update an existing reviewreport
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReviewreport(int id, Reviewreport reviewreport)
        {
            // Check if the provided id matches the reviewreport's id
            if (id != reviewreport.Id)
            {
                return BadRequest();
            }

            // Update the reviewreport in the repository
            _unitOfWork.Reviewreports.Update(reviewreport);

            try
            {
                // Save changes to the database
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // If the reviewreport doesn't exist
                if (!await ReviewreportExists(id))
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

        // POST: api/Reviewreports
        // Action method to create a new reviewreport
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Reviewreport>> PostReviewreport(Reviewreport reviewreport)
        {
            // Insert the new reviewreport into the repository
            await _unitOfWork.Reviewreports.Insert(reviewreport);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetReviewreport", new { id = reviewreport.Id }, reviewreport);
        }

        // DELETE: api/Reviewreports/5
        // Action method to delete a reviewreport by id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReviewreport(int id)
        {
            // Retrieve the reviewreport by id
            var reviewreport = await _unitOfWork.Reviewreports.Get(q => q.Id == id);

            // If the reviewreport doesn't exist
            if (reviewreport == null)
            {
                return NotFound();
            }

            // Delete the reviewreport from the repository
            await _unitOfWork.Reviewreports.Delete(id);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // Private method to check if reviewreport with a given id exists
        private async Task<bool> ReviewreportExists(int id)
        {
            var reviewreport = await _unitOfWork.Reviewreports.Get(q => q.Id == id);
            return reviewreport != null;
        }
    }
}

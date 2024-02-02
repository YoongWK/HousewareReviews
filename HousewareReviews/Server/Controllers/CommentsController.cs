using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HousewareReviews.Shared.Domain;
using HousewareReviews.Server.IRepository;

namespace HousewareReviews.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        // Define the IUnitOfWork instance
        private readonly IUnitOfWork _unitOfWork;

        // Constructor that takes the IUnitOfWork instance
        public CommentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Comments
        // Action method to retrieve all comments
        [HttpGet]
        public async Task<IActionResult> GetComments()
        {
            var comments = await _unitOfWork.Comments.GetAll(includes: q => q.Include(x => x.Review).Include(x => x.Consumer));
            return Ok(comments);
        }

        // GET: api/Comments/5
        // Action method to retrieve a specific comment by id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetComment(int id)
        {
            var comment = await _unitOfWork.Comments.Get(q => q.Id == id, includes: q => q.Include(x => x.Review).Include(x => x.Consumer));

            // Check if comment is not found
            if (comment == null)
            {
                return NotFound();
            }

            return Ok(comment);
        }

        // PUT: api/Comments/5
        // Action method to update an existing comment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComment(int id, Comment comment)
        {
            // Check if the provided id matches the comment's id
            if (id != comment.Id)
            {
                return BadRequest();
            }

            // Update the comment in the repository
            _unitOfWork.Comments.Update(comment);

            try
            {
                // Save changes to the database
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // If the comment doesn't exist
                if (!await CommentExists(id))
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

        // POST: api/Comments
        // Action method to create a new comment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Comment>> PostComment(Comment comment)
        {
            // Insert the new comment into the repository
            await _unitOfWork.Comments.Insert(comment);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetComment", new { id = comment.Id }, comment);
        }

        // DELETE: api/Comments/5
        // Action method to delete a comment by id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            // Retrieve the comment by id
            var comment = await _unitOfWork.Comments.Get(q => q.Id == id);

            // If the comment doesn't exist
            if (comment == null)
            {
                return NotFound();
            }

            // Delete the comment from the repository
            await _unitOfWork.Comments.Delete(id);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // Private method to check if comment with a given id exists
        private async Task<bool> CommentExists(int id)
        {
            var comment = await _unitOfWork.Comments.Get(q => q.Id == id);
            return comment != null;
        }
    }
}

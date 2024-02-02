using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HousewareReviews.Shared.Domain;
using HousewareReviews.Server.IRepository;

namespace HousewareReviews.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentreportsController : ControllerBase
    {
        // Define the IUnitOfWork instance
        private readonly IUnitOfWork _unitOfWork;

        // Constructor that takes the IUnitOfWork instance
        public CommentreportsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Commentreports
        // Action method to retrieve all commentreports
        [HttpGet]
        public async Task<ActionResult> GetCommentreports()
        {
            var commentreports = await _unitOfWork.Commentreports.GetAll(includes: q => q.Include(x => x.Comment).Include(x => x.Consumer).Include(x => x.Staff));
            return Ok(commentreports);
        }

        // GET: api/Commentreports/5
        // Action method to retrieve a specific commentreport by id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetCommentreport(int id)
        {
            var commentreport = await _unitOfWork.Commentreports.Get(q => q.Id == id, includes: q => q.Include(x => x.Comment).Include(x => x.Consumer).Include(x => x.Staff));

            // Check if commentreport is not found
            if (commentreport == null)
            {
                return NotFound();
            }

            return Ok(commentreport);
        }

        // PUT: api/Commentreports/5
        // Action method to update an existing commentreport
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommentreport(int id, Commentreport commentreport)
        {
            // Check if the provided id matches the commentreport's id
            if (id != commentreport.Id)
            {
                return BadRequest();
            }

            // Update the commentreport in the repository
            _unitOfWork.Commentreports.Update(commentreport);

            try
            {
                // Save changes to the database
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // If the commentreport doesn't exist
                if (!await CommentreportExists(id))
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

        // POST: api/Commentreports
        // Action method to create a new commentreport
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Commentreport>> PostCommentreport(Commentreport commentreport)
        {
            // Insert the new commentreport into the repository
            await _unitOfWork.Commentreports.Insert(commentreport);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCommentreport", new { id = commentreport.Id }, commentreport);
        }

        // DELETE: api/Commentreports/5
        // Action method to delete a commentreport by id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommentreport(int id)
        {
            // Retrieve the commentreport by id
            var commentreport = await _unitOfWork.Commentreports.Get(q => q.Id == id);

            // If the commentreport doesn't exist
            if (commentreport == null)
            {
                return NotFound();
            }

            // Delete the commentreport from the repository
            await _unitOfWork.Commentreports.Delete(id);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // Private method to check if commentreport with a given id exists
        private async Task<bool> CommentreportExists(int id)
        {
            var commentreport = await _unitOfWork.Commentreports.Get(q => q.Id == id);
            return commentreport != null;
        }
    }
}

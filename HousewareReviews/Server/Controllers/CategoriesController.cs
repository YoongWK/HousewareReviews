using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HousewareReviews.Shared.Domain;
using HousewareReviews.Server.IRepository;

namespace HousewareReviews.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        // Define the IUnitOfWork instance
        private readonly IUnitOfWork _unitOfWork;

        // Constructor that takes the IUnitOfWork instance
        public CategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Categories
        // Action method to retrieve all categories
        [HttpGet]
        public async Task<IActionResult> GetCategories() 
        {
            var categories = await _unitOfWork.Categories.GetAll();
            return Ok(categories);
        }

        // GET: api/Categories/5
        // Action method to retrieve a specific category by id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var category = await _unitOfWork.Categories.Get(q => q.Id == id);

            // Check if category is not found
            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        // PUT: api/Categories/5
        // Action method to update an existing category
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, Category category)
        {
            // Check if the provided id matches the category's id
            if (id != category.Id)
            {
                return BadRequest();
            }

            // Update the category in the repository
            _unitOfWork.Categories.Update(category);

            try
            {
                // Save changes to the database
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // If the category doesn't exist
                if (!await CategoryExists(id))
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

        // POST: api/Categories
        // Action method to create a new category
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            // Insert the new category into the repository
            await _unitOfWork.Categories.Insert(category);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCategory", new { id = category.Id }, category);
        }

        // DELETE: api/Categories/5
        // Action method to delete a category by id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            // Retrieve the category by id
            var category = await _unitOfWork.Categories.Get(q => q.Id == id);

            // If the category doesn't exist
            if (category == null)
            {
                return NotFound();
            }

            // Delete the category from the repository
            await _unitOfWork.Categories.Delete(id);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // Private method to check if category with a given id exists
        private async Task<bool> CategoryExists(int id)
        {
            var category = await _unitOfWork.Categories.Get(q =>q.Id == id);
            return category != null;
        }
    }
}

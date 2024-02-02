using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HousewareReviews.Shared.Domain;
using HousewareReviews.Server.IRepository;

namespace HousewareReviews.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // Define the IUnitOfWork instance
        private readonly IUnitOfWork _unitOfWork;

        // Constructor that takes the IUnitOfWork instance
        public ProductsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Products
        // Action method to retrieve all products
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _unitOfWork.Products.GetAll(includes: q => q.Include(x => x.Company).Include(x => x.Category));
            return Ok(products);
        }

        // GET: api/Products/5
        // Action method to retrieve a specific product by id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetProduct(int id)
        {
            var product = await _unitOfWork.Products.Get(q => q.Id == id, includes: q => q.Include(x => x.Company).Include(x => x.Category));

            // Check if product is not found
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        // Action method to update an existing product
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            // Check if the provided id matches the product's id 
            if (id != product.Id)
            {
                return BadRequest();
            }

            // Update the product in the repository
            _unitOfWork.Products.Update(product);

            try
            {
                // Save changes to the database
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // If the product doesn't exist
                if (!await ProductExists(id))
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

        // POST: api/Products
        // Action method to create a new product
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            // Insert the new product into the repository
            await _unitOfWork.Products.Insert(product);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        // DELETE: api/Products/5
        // Action method to delete a product by id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            // Retrieve the product by id
            var product = await _unitOfWork.Products.Get(q => q.Id == id);

            // If the product doesn't exist
            if (product == null)
            {
                return NotFound();
            }

            // Delete the product from the repository
            await _unitOfWork.Products.Delete(id);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // Private method to check if product with a given id exists
        private async Task<bool> ProductExists(int id)
        {
            var product = await _unitOfWork.Products.Get(q => q.Id == id);
            return product != null;
        }
    }
}

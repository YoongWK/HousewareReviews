using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HousewareReviews.Shared.Domain;
using HousewareReviews.Server.IRepository;

namespace HousewareReviews.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumersController : ControllerBase
    {
        // Define the IUnitOfWork instance
        private readonly IUnitOfWork _unitOfWork;

        // Constructor that takes the IUnitOfWork instance
        public ConsumersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Consumers
        // Action method to retrieve all consumers
        [HttpGet]
        public async Task<IActionResult> GetConsumers()
        {
            var consumers = await _unitOfWork.Consumers.GetAll();
            return Ok(consumers);
        }

        // GET: api/Consumers/5
        // Action method to retrieve a specific consumer by id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConsumer(int id)
        {
            var consumer = await _unitOfWork.Consumers.Get(q => q.Id == id);

            // Check if product is not found
            if (consumer == null)
            {
                return NotFound();
            }

            return Ok(consumer);
        }

        // PUT: api/Consumers/5
        // Action method to update an existing consumer
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsumer(int id, Consumer consumer)
        {
            // Check if the provided id matches the consumer's id
            if (id != consumer.Id)
            {
                return BadRequest();
            }

            // Update the consumer in the repository
            _unitOfWork.Consumers.Update(consumer);

            try
            {
                // Save changes to the database
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // If the consumer doesn't exist
                if (!await ConsumerExists(id))
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

        // POST: api/Consumers
        // Action method to create a new consumer
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Consumer>> PostConsumer(Consumer consumer)
        {
            // Insert the new consumer into the repository
            await _unitOfWork.Consumers.Insert(consumer);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetConsumer", new { id = consumer.Id }, consumer);
        }

        // DELETE: api/Consumers/5
        // Action method to delete a consumer by id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsumer(int id)
        {
            // Retrieve the consumer by id
            var consumer = await _unitOfWork.Consumers.Get(q => q.Id == id);

            // If the consumer doesn't exist
            if (consumer == null)
            {
                return NotFound();
            }

            // Delete the consumer from the repository
            await _unitOfWork.Consumers.Delete(id);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // Private method to check if consumer with a given id exists
        private async Task<bool> ConsumerExists(int id)
        {
            var consumer = await _unitOfWork.Consumers.Get(q => q.Id == id);
            return consumer != null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HousewareReviews.Server.Data;
using HousewareReviews.Shared.Domain;
using HousewareReviews.Server.IRepository;

namespace HousewareReviews.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ConsumersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Consumers
        [HttpGet]
        public async Task<IActionResult> GetConsumers()
        {
            var consumers = await _unitOfWork.Consumers.GetAll();
            return Ok(consumers);
        }

        // GET: api/Consumers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConsumer(int id)
        {
            var consumer = await _unitOfWork.Consumers.Get(q => q.Id == id);
            if (consumer == null)
            {
                return NotFound();
            }

            return Ok(consumer);
        }

        // PUT: api/Consumers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsumer(int id, Consumer consumer)
        {
            if (id != consumer.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Consumers.Update(consumer);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
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
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Consumer>> PostConsumer(Consumer consumer)
        {
            await _unitOfWork.Consumers.Insert(consumer);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetConsumer", new { id = consumer.Id }, consumer);
        }

        // DELETE: api/Consumers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsumer(int id)
        {
            var consumer = await _unitOfWork.Consumers.Get(q => q.Id == id);
            if (consumer == null)
            {
                return NotFound();
            }
            await _unitOfWork.Consumers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ConsumerExists(int id)
        {
            var consumer = await _unitOfWork.Consumers.Get(q => q.Id == id);
            return consumer != null;
        }
    }
}

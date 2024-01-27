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
    public class ReviewreportsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReviewreportsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Reviewreports
        [HttpGet]
        public async Task<ActionResult> GetReviewreports()
        {
            var reviewreports = await _unitOfWork.Reviewreports.GetAll(includes: q => q.Include(x => x.Review).Include(x => x.Consumer).Include(x => x.Staff));
            return Ok(reviewreports);
        }

        // GET: api/Reviewreports/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetReviewreport(int id)
        {
            var reviewreport = await _unitOfWork.Reviewreports.Get(q => q.Id == id, includes: q => q.Include(x => x.Review).Include(x => x.Consumer).Include(x => x.Staff));
            if (reviewreport == null)
            {
                return NotFound();
            }

            return Ok(reviewreport);
        }

        // PUT: api/Reviewreports/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReviewreport(int id, Reviewreport reviewreport)
        {
            if (id != reviewreport.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Reviewreports.Update(reviewreport);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
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
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Reviewreport>> PostReviewreport(Reviewreport reviewreport)
        {
            await _unitOfWork.Reviewreports.Insert(reviewreport);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetReviewreport", new { id = reviewreport.Id }, reviewreport);
        }

        // DELETE: api/Reviewreports/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReviewreport(int id)
        {
            var reviewreport = await _unitOfWork.Reviewreports.Get(q => q.Id == id);
            if (reviewreport == null)
            {
                return NotFound();
            }
            await _unitOfWork.Reviewreports.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ReviewreportExists(int id)
        {
            var reviewreport = await _unitOfWork.Reviewreports.Get(q => q.Id == id);
            return reviewreport != null;
        }
    }
}
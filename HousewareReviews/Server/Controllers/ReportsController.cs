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
    public class ReportsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReportsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Reports
        [HttpGet]
        public async Task<ActionResult> GetReports()
        {
            var reports = await _unitOfWork.Reports.GetAll();
            return Ok(reports);
        }

        // GET: api/Reports/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetReport(int id)
        {
            var report = await _unitOfWork.Reports.Get(q => q.Id == id);
            if (report == null)
            {
                return NotFound();
            }

            return Ok(report);
        }

        // PUT: api/Reports/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReport(int id, Report report)
        {
            if (id != report.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Reports.Update(report);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ReportExists(id))
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

        // POST: api/Reports
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Report>> PostReport(Report report)
        {
            await _unitOfWork.Reports.Insert(report);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetReport", new { id = report.Id }, report);
        }

        // DELETE: api/Reports/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReport(int id)
        {
            var report = await _unitOfWork.Categories.Get(q => q.Id == id);
            if (report == null)
            {
                return NotFound();
            }
            await _unitOfWork.Categories.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ReportExists(int id)
        {
            var report = await _unitOfWork.Reports.Get(q => q.Id == id);
            return report != null;
        }
    }
}

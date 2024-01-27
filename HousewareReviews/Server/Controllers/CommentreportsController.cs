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
    public class CommentreportsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentreportsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Commentreports
        [HttpGet]
        public async Task<ActionResult> GetCommentreports()
        {
            var commentreports = await _unitOfWork.Commentreports.GetAll(includes: q => q.Include(x => x.Comment).Include(x => x.Consumer).Include(x => x.Staff));
            return Ok(commentreports);
        }

        // GET: api/Commentreports/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetCommentreport(int id)
        {
            var commentreport = await _unitOfWork.Commentreports.Get(q => q.Id == id, includes: q => q.Include(x => x.Comment).Include(x => x.Consumer).Include(x => x.Staff));
            if (commentreport == null)
            {
                return NotFound();
            }

            return Ok(commentreport);
        }

        // PUT: api/Commentreports/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommentreport(int id, Commentreport commentreport)
        {
            if (id != commentreport.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Commentreports.Update(commentreport);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
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
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Commentreport>> PostCommentreport(Commentreport commentreport)
        {
            await _unitOfWork.Commentreports.Insert(commentreport);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCommentreport", new { id = commentreport.Id }, commentreport);
        }

        // DELETE: api/Commentreports/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommentreport(int id)
        {
            var commentreport = await _unitOfWork.Commentreports.Get(q => q.Id == id);
            if (commentreport == null)
            {
                return NotFound();
            }
            await _unitOfWork.Commentreports.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> CommentreportExists(int id)
        {
            var commentreport = await _unitOfWork.Commentreports.Get(q => q.Id == id);
            return commentreport != null;
        }
    }
}
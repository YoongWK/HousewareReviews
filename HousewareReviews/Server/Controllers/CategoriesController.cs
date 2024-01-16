﻿using System;
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
    public class CategoriesController : ControllerBase
    {
        // private readonly ApplicationDbContext _context;
        //Refactored
        private readonly IUnitOfWork _unitOfWork;

        //public CategoriesController(ApplicationDbContext context)
        public CategoriesController(IUnitOfWork unitOfWork)
        {
            // _context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Categories
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        public async Task<IActionResult> GetCategories() 
        {
            /*if (_context.Categories == null)
            {
                return NotFound();
            }
            return await _context.Categories.ToListAsync();
            */
            var categories = await _unitOfWork.Categories.GetAll();
            return Ok(categories);
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Category>> GetCategory(int id)
        public async Task<IActionResult> GetCategory(int id)
        {
          /*if (_context.Categories == null)
          {
              return NotFound();
          }*/
            //var category = await _context.Categories.FindAsync(id);
            var category = await _unitOfWork.Categories.Get(q => q.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, Category category)
        {
            if (id != category.Id)
            {
                return BadRequest();
            }

            // _context.Entry(category).State = EntityState.Modified;
            _unitOfWork.Categories.Update(category);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!CategoryExists(id))
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
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
          /*if (_context.Categories == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Categories'  is null.");
          }
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();*/
            await _unitOfWork.Categories.Insert(category);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCategory", new { id = category.Id }, category);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            /*if (_context.Categories == null)
            {
                return NotFound();
            }
            var category = await _context.Categories.FindAsync(id);*/
            var category = await _unitOfWork.Categories.Get(q => q.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            /*_context.Categories.Remove(category);
            await _context.SaveChangesAsync();*/
            await _unitOfWork.Categories.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool CategoryExists(int id)
        private async Task<bool> CategoryExists(int id)
        {
            var category = await _unitOfWork.Categories.Get(q =>q.Id == id);
            return category != null;
            /*return (_context.Categories?.Any(e => e.Id == id)).GetValueOrDefault();*/
        }
    }
}

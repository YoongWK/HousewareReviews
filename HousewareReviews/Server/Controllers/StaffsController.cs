using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HousewareReviews.Shared.Domain;
using HousewareReviews.Server.IRepository;

namespace HousewareReviews.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        // Define the IUnitOfWork instance
        private readonly IUnitOfWork _unitOfWork;

        // Constructor that takes the IUnitOfWork instance
        public StaffsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Staffs
        // Action method to retrieve all staffs
        [HttpGet]
        public async Task<ActionResult> GetStaffs()
        {
            var staffs = await _unitOfWork.Staffs.GetAll();
            return Ok(staffs);
        }

        // GET: api/Staffs/5
        // Action method to retrieve a specific staff by id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetStaff(int id)
        {
            var staff = await _unitOfWork.Staffs.Get(q => q.Id == id);

            // Check if staff is not found
            if (staff == null)
            {
                return NotFound();
            }

            return Ok(staff);
        }

        // PUT: api/Staffs/5
        // Action method to update an existing staff
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaff(int id, Staff staff)
        {
            // Check if the provided id matches the staff's id
            if (id != staff.Id)
            {
                return BadRequest();
            }

            // Update the staff in the repository
            _unitOfWork.Staffs.Update(staff);

            try
            {
                // Save changes to the database
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // If the staff doesn't exist
                if (!await StaffExists(id))
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

        // POST: api/Staffs
        // Action method to create a new staff
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Staff>> PostStaff(Staff staff)
        {
            // Insert the new staff into the repository
            await _unitOfWork.Staffs.Insert(staff);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetStaff", new { id = staff.Id }, staff);
        }

        // DELETE: api/Staffs/5
        // Action method to delete a staff by id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            // Retrieve the staff by id
            var staff = await _unitOfWork.Staffs.Get(q => q.Id == id);

            // If the staff doesn't exist
            if (staff == null)
            {
                return NotFound();
            }

            // Delete the staff from the repository
            await _unitOfWork.Staffs.Delete(id);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // Private method to check if staff with a given id exists
        private async Task<bool> StaffExists(int id)
        {
            var staff = await _unitOfWork.Staffs.Get(q => q.Id == id);
            return staff != null;
        }
    }
}

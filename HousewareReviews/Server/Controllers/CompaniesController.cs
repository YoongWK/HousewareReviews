using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HousewareReviews.Shared.Domain;
using HousewareReviews.Server.IRepository;

namespace HousewareReviews.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        // Define the IUnitOfWork instance
        private readonly IUnitOfWork _unitOfWork;

        // Constructor that takes the IUnitOfWork instance
        public CompaniesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Companies
        // Action method to retrieve all companies
        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            var companies = await _unitOfWork.Companies.GetAll();
            return Ok(companies);
        }

        // GET: api/Companies/5
        // Action method to retrieve a specific company by id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompany(int id)
        {
            var company = await _unitOfWork.Companies.Get(q => q.Id == id);

            // Check if company is not found
            if (company == null)
            {
                return NotFound();
            }

            return Ok(company);
        }

        // PUT: api/Companies/5
        // Action method to update an existing company
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(int id, Company company)
        {
            // Check if the provided id matches the company's id
            if (id != company.Id)
            {
                return BadRequest();
            }

            // Update the company in the repository
            _unitOfWork.Companies.Update(company);

            try
            {
                // Save changes to the database
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // If the company doesn't exist
                if (!await CompanyExists(id))
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

        // POST: api/Companies
        // Action method to create a new company
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Company>> PostCompany(Company company)
        {
            // Insert the new company into the repository
            await _unitOfWork.Companies.Insert(company);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCompany", new { id = company.Id }, company);
        }

        // DELETE: api/Companies/5
        // Action method to delete a company by id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            // Retrieve the company by id
            var company = await _unitOfWork.Companies.Get(q => q.Id == id);

            // If the company doesn't exist
            if (company == null)
            {
                return NotFound();
            }

            // Delete the company from the repository
            await _unitOfWork.Companies.Delete(id);
            // Save changes to the database
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // Private method to check if company with a given id exists
        private async Task<bool> CompanyExists(int id)
        {
            var company = await _unitOfWork.Companies.Get(q => q.Id == id);
            return company != null;
        }
    }
}

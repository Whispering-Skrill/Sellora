using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sellora.Server.Data;
using Sellora.Server.IRepository;
using Sellora.Shared.Domain;

namespace Sellora.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        // Refactored - Create UnitOfWork instance
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        // Refactored - Dependency injection
        //public StaffsController(ApplicationDbContext context)
        public StaffsController(IUnitOfWork unitOfWork)
        {
            // Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Staffs - This method gets all values/data within the Staff Table of the Database
        [HttpGet]
        // Refactored
        //public async Task<ActionResult<IEnumerable<Staff>>> GetStaff()
        public async Task<IActionResult> GetStaffs()
        {
            // For Error Handling Test
            // return NotFound();

            // Refactored
            //if (_context.Staff == null)
            //{
            //    return NotFound();
            //}
            //    return await _context.Staff.ToListAsync();

            // This returns a 404 if the Staff table is empty
            //if (_unitOfWork.Staffs == null)
            //{
            //    return NotFound();
            //}

            // Gets All values within the Staff Table
            var staffs = await _unitOfWork.Staffs.GetAll();
            return Ok(staffs);
        }

        // GET: api/Staffs/5 - This method gets the data of specific tuple/row within the Staff table by specifying the ID
        [HttpGet("{id}")]
        // Refactored
        //public async Task<ActionResult<Staff>> GetStaff(int id)
        public async Task<IActionResult> GetStaff(int id)
        {
            // Refactored
            //if (_context.Staff == null)
            //{
            //    return NotFound();
            //}
            //  var staff = await _context.Staff.FindAsync(id);
            //
            //  if (staff == null)
            //  {
            //      return NotFound();
            //  }

            // return staff;

            // This returns a 404 if the Staff table is empty
            //if (_unitOfWork.Staffs == null)
            //{
            //    return NotFound();
            //}
            // This checks if a tuple with the specified ID exists in the Staff Table
            var staff = await _unitOfWork.Staffs.Get(q => q.Id == id);
            if (staff == null)
            {
                // Returns a resource not found error
                return NotFound(id);
            }

            return Ok(staff);
        }

        // PUT: api/Staffs/5 - This method updates a tuple/resource within the Staff table with a specified ID
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaff(int id, Staff staff)
        {
            // This checks if the value given is a Staff ID
            if (id != staff.Id)
            {
                // Returns a Bad Request error
                return BadRequest();
            }

            // Refactored
            //_context.Entry(staff).State = EntityState.Modified;

            // This updates the Staff Table
            _unitOfWork.Staffs.Update(staff);

            try
            {
                // Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // Refactored
                //if (!StaffExists(id))

                // This checks if there are values in the Staff Table with a specified ID
                if (!await StaffExists(id))
                {
                    // Returns a resource not found error
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        // POST: api/Staffs - This method creates a new tuple/resource within the Staff table with a user input or data from the browser
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Staff>> PostStaff(Staff staff)
        {
            // Refactored
            //if (_context.Staff == null)

            // This returns a 404 if the Staff table is empty
            //if (_unitOfWork.Staffs == null)
            //{
            //    return Problem("Entity set 'ApplicationDbContext.Staff'  is null.");
            //}

            // Refactored  
            //_context.Staff.Add(staff);
            //await _context.SaveChangesAsync();

            // This adds/inserts a new value/row/tuple into the Staff Table
            await _unitOfWork.Staffs.Insert(staff);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetStaff", new { id = staff.Id }, staff);
        }

        // DELETE: api/Staffs/5 - This method is called to delete a tuple within the Staff table, this tuple is specified by the ID of the tuple
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            // Refactored
            //if (_context.Staffs == null)

            // This returns a 404 if the Staff table is empty
            //if (_unitOfWork.Staffs == null)
            //{
            //    return NotFound();
            //}

            // Refactored
            //var staff = await _context.Staff.FindAsync(id);

            // This checks if a tuple with the specified ID exists in the Staff Table
            var staff = await _unitOfWork.Staffs.Get(q => q.Id == id);
            if (staff == null)
            {
                // Returns a resource not found error
                return NotFound();
            }

            // Refactored
            //_context.Staff.Remove(staff);
            //await _context.SaveChangesAsync();

            // This deletes the tuple specified by the ID
            await _unitOfWork.Staffs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // Staff Exists - This method is called by the above methods to check if a tuple/data with a specified ID exists within the Staff Table
        // Refactored
        //private bool StaffExists(int id)
        private async Task<bool> StaffExists(int id)
        {
            // Refactored
            //return (_context.Staff?.Any(e => e.Id == id)).GetValueOrDefault();
            var staff = await _unitOfWork.Staffs.Get(q => q.Id == id);
            return staff != null;
        }
    }
}

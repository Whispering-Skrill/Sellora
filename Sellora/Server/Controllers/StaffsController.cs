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
        private readonly IUnitOfWork _unitOfWork;

        public StaffsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Staffs - This method gets all values/data within the Staff Table of the Database
        [HttpGet]
        public async Task<IActionResult> GetStaffs()
        {
            // Gets All values within the Staff Table
            var staffs = await _unitOfWork.Staffs.GetAll();
            return Ok(staffs);
        }

        // GET: api/Staffs/5 - This method gets the data of specific tuple/row within the Staff table by specifying the ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStaff(int id)
        {
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

            // This updates the Staff Table
            _unitOfWork.Staffs.Update(staff);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
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

        // POST: api/Staffs - This method creates a new tuple/resource within the Staff table with a
        // user input or data from the browser
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Staff>> PostStaff(Staff staff)
        {
            // This adds/inserts a new value/row/tuple into the Staff Table
            await _unitOfWork.Staffs.Insert(staff);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetStaff", new { id = staff.Id }, staff);
        }

        // DELETE: api/Staffs/5 - This method is called to delete a tuple within the Staff table, this
        // tuple is specified by the ID of the tuple
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            // This checks if a tuple with the specified ID exists in the Staff Table
            var staff = await _unitOfWork.Staffs.Get(q => q.Id == id);
            if (staff == null)
            {
                // Returns a resource not found error
                return NotFound();
            }

            // This deletes the tuple specified by the ID
            await _unitOfWork.Staffs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // Staff Exists - This method is called by the above methods to check if a tuple/data with
        // a specified ID exists within the Staff Table
        private async Task<bool> StaffExists(int id)
        {
            var staff = await _unitOfWork.Staffs.Get(q => q.Id == id);
            return staff != null;
        }
    }
}

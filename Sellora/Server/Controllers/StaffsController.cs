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
        // Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        // Refactored
        //public StaffsController(ApplicationDbContext context)
        public StaffsController(IUnitOfWork unitOfWork)
        {
            // Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Staffs
        [HttpGet]
        // Refactored
        //public async Task<ActionResult<IEnumerable<Staff>>> GetStaff()
        public async Task<IActionResult> GetStaff()
        {
            // Refactored
            //if (_context.Staff == null)
            //{
            //    return NotFound();
            //}
            //    return await _context.Staff.ToListAsync();
            if (_unitOfWork.Staffs == null)
            {
                return NotFound();
            }
            var staffs = await _unitOfWork.Staffs.GetAll();
            return Ok(staffs);
        }

        // GET: api/Staffs/5
        [HttpGet("{id}")]
        // Refactored
        //public async Task<ActionResult<Staff>> GetStaff(int id)
        public async Task<IActionResult> getStaff(int id)
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

            if (_unitOfWork.Staffs == null)
            {
                return NotFound();
            }
            
            var staff = await _unitOfWork.Staffs.Get(q => q.Id == id);
              
            if (staff == null)
            {
                return NotFound(id);
            }

            return Ok(staff);
        }

        // PUT: api/Staffs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaff(int id, Staff staff)
        {
            if (id != staff.Id)
            {
                return BadRequest();
            }

            // Refactored
            //_context.Entry(staff).State = EntityState.Modified;
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
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Staff>> PostStaff(Staff staff)
        {
            // Refactored
          //if (_context.Staff == null)
          if (_unitOfWork.Staffs == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Staff'  is null.");
          }
            // Refactored  
            //_context.Staff.Add(staff);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Staffs.Insert(staff);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetStaff", new { id = staff.Id }, staff);
        }

        // DELETE: api/Staffs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            if (_unitOfWork.Staffs == null)
            {
                return NotFound();
            }
            // Refactored
            //var staff = await _context.Staff.FindAsync(id);
            var staff = await _unitOfWork.Staffs.Get(q => q.Id == id);
            if (staff == null)
            {
                return NotFound();
            }

            // Refactored
            //_context.Staff.Remove(staff);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Staffs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

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

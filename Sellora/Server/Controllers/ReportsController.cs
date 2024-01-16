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
    public class ReportsController : ControllerBase
    {
        // Refactored - Create UnitOfWork instance
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        // Refactored - Dependency injection
        //public ReportsController(ApplicationDbContext context)
        public ReportsController(IUnitOfWork unitOfWork)
        {
            // Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Reports - This method gets all values/data within the Reports Table of the Database
        [HttpGet]
        // Refactored
        //public async Task<ActionResult<IEnumerable<Report>>> GetReports()
        public async Task<IActionResult> GetReport()
        {
            // Refactored
            //if (_context.Reports == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.Reports.ToListAsync();

            // This checks if there are values in the Reports Table
            if (_unitOfWork.Reports == null)
            {
                return NotFound();
            }
            var reports = await _unitOfWork.Reports.GetAll();
            return Ok(reports);
        }

        // GET: api/Reports/5 - This method gets the data of specific tuple/row within the Reports table by specifying the ID
        [HttpGet("{id}")]
        // Refactored
        //public async Task<ActionResult<Report>> GetReport(int id)
        public async Task<ActionResult> GetReport(int id)
        {
            // Refactored
            //if (_context.Reports == null)
            //{
            //    return NotFound();
            //}
            //  var report = await _context.Reports.FindAsync(id);

            //  if (report == null)
            //  {
            //      return NotFound();
            //  }

            //  return report;

            // This checks if there are values in the Report Table
            if (_unitOfWork.Reports == null)
            {
                return NotFound();
            }

            // This checks if a tuple with the specified ID exists in the Report Table
            var report = await _unitOfWork.Reports.Get(q => q.Id == id);
            if (report == null)
            {
                return NotFound(id);
            }

            return Ok(report);
        }

        // PUT: api/Reports/5 - This method updates a tuple/resource within the Report table with a specified ID
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReport(int id, Report report)
        {
            // This checks if the value given is a Report ID
            if (id != report.Id)
            {
                return BadRequest();
            }

            // Refactored
            //_context.Entry(report).State = EntityState.Modified;

            // This updates the Report Table
            _unitOfWork.Reports.Update(report);

            try
            {
                // Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // Refactored
                //if (!ReportExists(id))

                // This checks if there are values in the Report Table with a specified ID
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

        // POST: api/Reports - This method creates a new tuple/resource within the Report table with a user input or data from the browser
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Report>> PostReport(Report report)
        {
            // Refactored
            //if (_context.Reports == null)

            // This checks if there are values in the Report Table
            if (_unitOfWork.Reports == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Reports'  is null.");
            }
            // Refactored
            //_context.Reports.Add(report);
            //await _context.SaveChangesAsync();

            // This adds/inserts a new value/row/tuple into the Report Table
            await _unitOfWork.Reports.Insert(report);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetReport", new { id = report.Id }, report);
        }

        // DELETE: api/Reports/5 - This method is called to delete a tuple within the Report table, this tuple is specified by the ID of the tuple
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReport(int id)
        {
            // Refactored
            //if (_context.Reports == null)
            if (_unitOfWork.Reports == null)
            {
                return NotFound();
            }
            // Refactored
            //var report = await _context.Reports.FindAsync(id);

            // This checks if a tuple with the specified ID exists in the Report Table
            var report = await _unitOfWork.Reports.Get(q => q.Id == id);
            if (report == null)
            {
                return NotFound();
            }

            // Refactored
            //_context.Reports.Remove(report);
            //await _context.SaveChangesAsync();

            // This deletes the tuple specified by the ID
            await _unitOfWork.Reports.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // Report Exists - This method is called by the above methods to check if a tuple/data with a specified ID exists within the SwapTransaction Table
        // Refactored
        //private bool ReportExists(int id)
        private async Task<bool> ReportExists(int id)
        {
            // Refactored
            //return (_context.Reports?.Any(e => e.Id == id)).GetValueOrDefault();
            var report = await _unitOfWork.Reports.Get(q => q.Id == id);
            return report != null;
        }
    }
}

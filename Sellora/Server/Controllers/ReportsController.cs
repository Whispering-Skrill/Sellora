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

// This is the Reports Contoller [Refactored]
namespace Sellora.Server.Controllers
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

        // GET: api/Reports - This method gets all values/data within the Reports Table of the Database
        [HttpGet]
        public async Task<IActionResult> GetReports()
        {
            var reports = await _unitOfWork.Reports.GetAll(includes:q=>q.Include(x=>x.AppUser).Include(x=>x.Staff).Include(x=>x.SwapTransaction).Include(x=>x.SaleTransaction));
            return Ok(reports);
        }

        // GET: api/Reports/5 - This method gets the data of specific tuple/row within the
        // Reports table by specifying the ID
        [HttpGet("{id}")]
        public async Task<ActionResult> GetReport(int id)
        {
            // This checks if a tuple with the specified ID exists in the Report Table
            var report = await _unitOfWork.Reports.Get(q => q.Id == id);
            if (report == null)
            {
                // Returns a resource not found error
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
                // Returns a bad request error
                return BadRequest();
            }

            // This updates the Report Table
            _unitOfWork.Reports.Update(report);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // This checks if there are values in the Report Table with a specified ID
                if (!await ReportExists(id))
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

        // POST: api/Reports - This method creates a new tuple/resource within the Report table with a
        // user input or data from the browser
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Report>> PostReport(Report report)
        {
            // This adds/inserts a new value/row/tuple into the Report Table
            await _unitOfWork.Reports.Insert(report);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetReport", new { id = report.Id }, report);
        }

        // DELETE: api/Reports/5 - This method is called to delete a tuple within the Report table,
        // this tuple is specified by the ID of the tuple
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReport(int id)
        {
            // This checks if a tuple with the specified ID exists in the Report Table
            var report = await _unitOfWork.Reports.Get(q => q.Id == id);
            if (report == null)
            {
                // Returns a resource not found error
                return NotFound();
            }

            // This deletes the tuple specified by the ID
            await _unitOfWork.Reports.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // Report Exists - This method is called by the above methods to check if a tuple/data with
        // a specified ID exists within the Reports Table
        private async Task<bool> ReportExists(int id)
        {
            var report = await _unitOfWork.Reports.Get(q => q.Id == id);
            return report != null;
        }
    }
}

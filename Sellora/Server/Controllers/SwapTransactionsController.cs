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
    public class SwapTransactionsController : ControllerBase
    {
        // Refactored - Create UnitOfWork instance
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        // Refactored - Dependency injection
        //public SwapTransactionsController(ApplicationDbContext context)
        public SwapTransactionsController(IUnitOfWork unitOfWork)
        {
            // Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/SwapTransactions - This method gets all values/data within the SwapTransaction Table of the Database
        [HttpGet]
        // Refactored
        //public async Task<ActionResult<IEnumerable<SwapTransaction>>> GetSwapTransactions()
        public async Task<IActionResult> GetSwapTransaction()
        {
            // Refactored
            //if (_context.SwapTransactions == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.SwapTransactions.ToListAsync();

            // This checks if there are values in the SwapTransactions Table
            if (_unitOfWork.SwapTransactions == null)
            {
                return NotFound();
            }

            // Gets All values within the SwapTransaction Table
            var swaptransactions = await _unitOfWork.SwapTransactions.GetAll();
            return Ok(swaptransactions);
        }

        // GET: api/SwapTransactions/5 - This method gets the data of specific tuple/row within the SwapTransaction table by specifying the ID
        [HttpGet("{id}")]
        // Refactored
        //public async Task<ActionResult<SwapTransaction>> GetSwapTransaction(int id)
        public async Task<ActionResult> GetSwapTransaction(int id)
        {
            // Refactored
            //if (_context.SwapTransactions == null)
            //{
            //    return NotFound();
            //}
            //  var swaptransaction = await _context.SwapTransactions.FindAsync(id);

            //  if (swaptransaction == null)
            //  {
            //      return NotFound();
            //  }

            //  return swaptransaction;

            // This checks if there are values in the SwapTransaction Table
            if (_unitOfWork.SwapTransactions == null)
            {
                return NotFound();
            }

            // This checks if a tuple with the specified ID exists in the SwapTransaction Table
            var swaptransaction = await _unitOfWork.SwapTransactions.Get(q => q.Id == id);
            if (swaptransaction == null)
            {
                return NotFound(id);
            }

            return Ok(swaptransaction);
        }

        // PUT: api/SwapTransactions/5 - This method updates a tuple/resource within the SwapTransaction table with a specified ID
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSwapTransaction(int id, SwapTransaction swaptransaction)
        {
            // This checks if the value given is a SwapTransaction ID
            if (id != swaptransaction.Id)
            {
                return BadRequest();
            }

            // Refactored
            //_context.Entry(swaptransaction).State = EntityState.Modified;

            // This updates the SwapTransaction Table
            _unitOfWork.SwapTransactions.Update(swaptransaction);

            try
            {
                // Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // Refactored
                //if (!SwapTransactionExists(id))

                // This checks if there are values in the SwapTransaction Table with a specified ID
                if (!await SwapTransactionExists(id))
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

        // POST: api/SwapTransactions - This method creates a new tuple/resource within the SwapTransaction table with a user input or data from the browser
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SwapTransaction>> PostSwapTransaction(SwapTransaction swaptransaction)
        {
            // Refactored
            //if (_context.SwapTransactions == null)

            // This checks if there are values in the SwapTransaction Table
            if (_unitOfWork.SwapTransactions == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SwapTransactions'  is null.");
            }
            // Refactored
            //_context.SwapTransactions.Add(swaptransaction);
            //await _context.SaveChangesAsync();

            // This adds/inserts a new value/row/tuple into the SwapTransaction Table
            await _unitOfWork.SwapTransactions.Insert(swaptransaction);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetSwapTransaction", new { id = swaptransaction.Id }, swaptransaction);
        }

        // DELETE: api/SwapTransactions/5 - This method is called to delete a tuple within the SwapTransaction table, this tuple is specified by the ID of the tuple
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSwapTransaction(int id)
        {
            // Refactored
            //if (_context.SwapTransactions == null)
            if (_unitOfWork.SwapTransactions == null)
            {
                return NotFound();
            }
            // Refactored
            //var swaptransaction = await _context.SwapTransactions.FindAsync(id);

            // This checks if a tuple with the specified ID exists in the SwapTransaction Table
            var swaptransaction = await _unitOfWork.SwapTransactions.Get(q => q.Id == id);
            if (swaptransaction == null)
            {
                return NotFound();
            }

            // Refactored
            //_context.SwapTransactions.Remove(swaptransaction);
            //await _context.SaveChangesAsync();

            // This deletes the tuple specified by the ID
            await _unitOfWork.SwapTransactions.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // SwapTransaction Exists - This method is called by the above methods to check if a tuple/data with a specified ID exists within the SwapTransaction Table
        // Refactored
        //private bool SwapTransactionExists(int id)
        private async Task<bool> SwapTransactionExists(int id)
        {
            // Refactored
            //return (_context.SwapTransactions?.Any(e => e.Id == id)).GetValueOrDefault();
            var swaptransaction = await _unitOfWork.SwapTransactions.Get(q => q.Id == id);
            return swaptransaction != null;
        }
    }
}

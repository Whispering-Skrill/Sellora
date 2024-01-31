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
        private readonly IUnitOfWork _unitOfWork;

        public SwapTransactionsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/SwapTransactions - This method gets all values/data within the SwapTransaction Table of the Database
        [HttpGet]
        public async Task<IActionResult> GetSwapTransactions()
        {
            // Gets All values within the SwapTransaction Table
            var swaptransactions = await _unitOfWork.SwapTransactions.GetAll(includes:q=>q.Include(x=>x.AppUser1).Include(x=>x.SwapItem1).Include(x => x.AppUser2).Include(x => x.SwapItem2));
            return Ok(swaptransactions);
        }

        // GET: api/SwapTransactions/5 - This method gets the data of specific tuple/row within
        // the SwapTransaction table by specifying the ID
        [HttpGet("{id}")]
        public async Task<ActionResult> GetSwapTransaction(int id)
        {
            // This checks if a tuple with the specified ID exists in the SwapTransaction Table
            var swaptransaction = await _unitOfWork.SwapTransactions.Get(q => q.Id == id);
            if (swaptransaction == null)
            {
                // Returns a resource not found error
                return NotFound(id);
            }

            return Ok(swaptransaction);
        }

        // PUT: api/SwapTransactions/5 - This method updates a tuple/resource within the SwapTransaction table with a
        // specified ID
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSwapTransaction(int id, SwapTransaction swaptransaction)
        {
            // This checks if the value given is a SwapTransaction ID
            if (id != swaptransaction.Id)
            {
                // Returns a bad request error
                return BadRequest();
            }

            // This updates the SwapTransaction Table
            _unitOfWork.SwapTransactions.Update(swaptransaction);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // This checks if there are values in the SwapTransaction Table with a specified ID
                if (!await SwapTransactionExists(id))
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

        // POST: api/SwapTransactions - This method creates a new tuple/resource within the SwapTransaction table
        // with a user input or data from the browser
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SwapTransaction>> PostSwapTransaction(SwapTransaction swaptransaction)
        {
            // This adds/inserts a new value/row/tuple into the SwapTransaction Table
            await _unitOfWork.SwapTransactions.Insert(swaptransaction);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetSwapTransaction", new { id = swaptransaction.Id }, swaptransaction);
        }

        // DELETE: api/SwapTransactions/5 - This method is called to delete a tuple within the SwapTransaction table,
        // this tuple is specified by the ID of the tuple
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSwapTransaction(int id)
        {
            // This checks if a tuple with the specified ID exists in the SwapTransaction Table
            var swaptransaction = await _unitOfWork.SwapTransactions.Get(q => q.Id == id);
            if (swaptransaction == null)
            {
                // Returns a resource not found error
                return NotFound();
            }

            // This deletes the tuple specified by the ID
            await _unitOfWork.SwapTransactions.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // SwapTransaction Exists - This method is called by the above methods to check if a tuple/data with
        // a specified ID exists within the SwapTransaction Table
        private async Task<bool> SwapTransactionExists(int id)
        {
            var swaptransaction = await _unitOfWork.SwapTransactions.Get(q => q.Id == id);
            return swaptransaction != null;
        }
    }
}

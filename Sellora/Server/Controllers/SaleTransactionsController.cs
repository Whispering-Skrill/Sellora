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
    public class SaleTransactionsController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public SaleTransactionsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/SaleTransactions
        [HttpGet]

        public async Task<IActionResult> GetSaleTransactions()
        {
            var saletransactions = await _unitOfWork.SaleTransactions.GetAll();
            return Ok(saletransactions);
        }

        // GET: api/SaleTransactions/5
        [HttpGet("{id}")]

        public async Task<IActionResult> GetSaleTransaction(int id)
        {
            var saletransaction = await _unitOfWork.SaleTransactions.Get(q => q.Id == id);

            if (saletransaction == null)
            {
                return NotFound();
            }

            return Ok(saletransaction);
        }

        // PUT: api/SaleTransactions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSaleTransaction(int id, SaleTransaction saletransaction)
        {
            if (id != saletransaction.Id)
            {
                return BadRequest();
            }

            _unitOfWork.SaleTransactions.Update(saletransaction);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await SaleTransactionExists(id))
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

        // POST: api/SaleTransactions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SaleTransaction>> PostSaleTransaction(SaleTransaction saletransaction)
        {
          if (_unitOfWork.SaleTransactions == null)
          {
              return Problem("Entity set 'SaleTransactionsController.SaleTransactions'  is null.");
          }
            await _unitOfWork.SaleTransactions.Insert(saletransaction);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetSaleTransaction", new { id = saletransaction.Id }, saletransaction);
        }

        // DELETE: api/SaleTransactions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSaleTransaction(int id)
        {
            var saletransaction = await _unitOfWork.SaleTransactions.Get(q => q.Id == id);
            if (saletransaction == null)
            {
                return NotFound();
            }

            await _unitOfWork.SaleTransactions.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> SaleTransactionExists(int id)
        {
            var saletransaction = await _unitOfWork.SaleTransactions.Get(e => e.Id == id);
            return saletransaction != null;
        }
    }
}

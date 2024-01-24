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
    public class ItemsController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public ItemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Items
        [HttpGet]

        public async Task<IActionResult> GetItems()
        {
            var items = await _unitOfWork.Items.GetAll(includes: q => q.Include(x => x.AppUser));
            return Ok(items);
        }

        // GET: api/Items/5
        [HttpGet("{id}")]

        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _unitOfWork.Items.Get(q => q.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // PUT: api/Items/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItem(int id, Item item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Items.Update(item);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ItemExists(id))
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

        // POST: api/Items
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Item>> PostItem(Item item)
        {
          if (_unitOfWork.Items == null)
          {
              return Problem("Entity set 'ItemsController.Items'  is null.");
          }
            await _unitOfWork.Items.Insert(item);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetItem", new { id = item.Id }, item);
        }

        // DELETE: api/Items/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var item = await _unitOfWork.Items.Get(q => q.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            await _unitOfWork.Items.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ItemExists(int id)
        {
            var item = await _unitOfWork.Items.Get(e => e.Id == id);
            return item != null;
        }
    }
}

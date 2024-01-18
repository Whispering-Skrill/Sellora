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

        private readonly ApplicationDbContext _context;

        public ItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Items
        [HttpGet]

        public async Task<IActionResult> GetItems()
        {
            var categories = await _unitOfWork.Items.GetAll();
            return Ok(categories);
        }

        // GET: api/Items/5
        [HttpGet("{id}")]

        public async Task<IActionResult> GetItem(int id)
        {
            var category = await _unitOfWork.Items.Get(q => q.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        // PUT: api/Items/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItem(int id, Item category)
        {
            if (id != category.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Items.Update(category);

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
        public async Task<ActionResult<Item>> PostItem(Item category)
        {
          if (_context.Items == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Items'  is null.");
          }
            await _unitOfWork.Items.Insert(category);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetItem", new { id = category.Id }, category);
        }

        // DELETE: api/Items/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var category = await _unitOfWork.Items.Get(q => q.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            await _unitOfWork.Items.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ItemExists(int id)
        {
            var category = await _unitOfWork.Items.Get(e => e.Id == id);
            return category != null;
        }
    }
}

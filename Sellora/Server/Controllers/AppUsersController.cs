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
    public class AppUsersController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public AppUsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/AppUsers
        [HttpGet]

        public async Task<IActionResult> GetAppUsers()
        {
            var appusers = await _unitOfWork.AppUsers.GetAll();
            return Ok(appusers);
        }

        // GET: api/AppUsers/5
        [HttpGet("{id}")]

        public async Task<IActionResult> GetAppUser(int id)
        {
            var appuser = await _unitOfWork.AppUsers.Get(q => q.Id == id);

            if (appuser == null)
            {
                return NotFound();
            }

            return Ok(appuser);
        }

        // PUT: api/AppUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppUser(int id, AppUser appuser)
        {
            if (id != appuser.Id)
            {
                return BadRequest();
            }

            _unitOfWork.AppUsers.Update(appuser);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AppUserExists(id))
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

        // POST: api/AppUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AppUser>> PostAppUser(AppUser appuser)
        {
          if (_unitOfWork.AppUsers == null)
          {
              return Problem("Entity set 'AppUsersController.AppUsers'  is null.");
          }
            await _unitOfWork.AppUsers.Insert(appuser);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAppUser", new { id = appuser.Id }, appuser);
        }

        // DELETE: api/AppUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppUser(int id)
        {
            var appuser = await _unitOfWork.AppUsers.Get(q => q.Id == id);
            if (appuser == null)
            {
                return NotFound();
            }

            await _unitOfWork.AppUsers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AppUserExists(int id)
        {
            var appuser = await _unitOfWork.AppUsers.Get(e => e.Id == id);
            return appuser != null;
        }
    }
}

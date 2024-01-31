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
    public class ReviewsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReviewsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Reviews - This method gets all values/data within the Reviews Table of the Database
        [HttpGet]
        public async Task<IActionResult> GetReviews()
        {
            var reviews = await _unitOfWork.Reviews.GetAll(includes:q=>q.Include(x=>x.SaleTransaction).Include(x=>x.SwapTransaction).Include(x=>x.AppUser));
            return Ok(reviews);
        }

        // GET: api/Reviews/5 - This method gets the data of specific tuple/row within the
        // Reviews table by specifying the ID
        [HttpGet("{id}")]
        // Refactored
        //public async Task<ActionResult<Review>> GetReview(int id)
        public async Task<ActionResult> GetReview(int id)
        {
            // This checks if a tuple with the specified ID exists in the Review Table
            var review = await _unitOfWork.Reviews.Get(q => q.Id == id);
            if (review == null)
            {
                // Returns a resource not found error
                return NotFound(id);
            }

            return Ok(review);
        }

        // PUT: api/Reviews/5 - This method updates a tuple/resource within the Review table with a specified ID
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReview(int id, Review review)
        {
            // This checks if the value given is a Review ID
            if (id != review.Id)
            {
                // Returns a Bad Request error
                return BadRequest();
            }

            // This updates the Review Table
            _unitOfWork.Reviews.Update(review);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // This checks if there are values in the Review Table with a specified ID
                if (!await ReviewExists(id))
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

        // POST: api/Reviews - This method creates a new tuple/resource within the Review table with a
        // user input or data from the browser
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Review>> PostReview(Review review)
        {
            // This adds/inserts a new value/row/tuple into the Review Table
            await _unitOfWork.Reviews.Insert(review);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetReview", new { id = review.Id }, review);
        }

        // DELETE: api/Reviews/5 - This method is called to delete a tuple within the Review table,
        // this tuple is specified by the ID of the tuple
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            // This checks if a tuple with the specified ID exists in the Review Table
            var review = await _unitOfWork.Reviews.Get(q => q.Id == id);
            if (review == null)
            {
                // Returns a resource not found error
                return NotFound();
            }

            // This deletes the tuple specified by the ID
            await _unitOfWork.Reviews.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // Review Exists - This method is called by the above methods to check if a tuple/data with
        // a specified ID exists within the Reviews Table
        private async Task<bool> ReviewExists(int id)
        {
            var review = await _unitOfWork.Reviews.Get(q => q.Id == id);
            return review != null;
        }
    }
}

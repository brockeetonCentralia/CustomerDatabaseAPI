using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CustomerDatabaseApi.Server.Data;
using CustomerDatabaseApi.Server.Models;

namespace CustomerDatabaseApi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerInfoController : ControllerBase
    {
        private readonly CustomerDatabaseApiContext _context;

        public CustomerInfoController(CustomerDatabaseApiContext context)
        {
            _context = context;
        }

        // GET: api/CustomerInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerInfo>>> GetcustomerInfo()
        {
            return await _context.customerInfo.ToListAsync();
        }

        // GET: api/CustomerInfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerInfo>> GetCustomerInfo(int id)
        {
            var customerInfo = await _context.customerInfo.FindAsync(id);

            if (customerInfo == null)
            {
                return NotFound();
            }

            return customerInfo;
        }

        // PUT: api/CustomerInfo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerInfo(int id, CustomerInfo customerInfo)
        {
            if (id != customerInfo.CustomerID)
            {
                return BadRequest();
            }

            _context.Entry(customerInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerInfoExists(id))
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

        // POST: api/CustomerInfo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerInfo>> PostCustomerInfo(CustomerInfo customerInfo)
        {
            _context.customerInfo.Add(customerInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerInfo", new { id = customerInfo.CustomerID }, customerInfo);
        }

        // DELETE: api/CustomerInfo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerInfo(int id)
        {
            var customerInfo = await _context.customerInfo.FindAsync(id);
            if (customerInfo == null)
            {
                return NotFound();
            }

            _context.customerInfo.Remove(customerInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerInfoExists(int id)
        {
            return _context.customerInfo.Any(e => e.CustomerID == id);
        }
    }
}

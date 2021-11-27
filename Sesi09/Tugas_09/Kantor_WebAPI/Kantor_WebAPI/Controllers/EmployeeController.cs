using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Kantor_WebAPI.Models;

namespace Kantor_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            this._context = context;
        }

        // GET: api/User
        [HttpGet]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetAllEmployee();
        }

        //POST: api/User
        [HttpPost]
        public ActionResult<IEnumerable<EmployeeItem>> PostEmployeeItem(EmployeeItem item)
        {
            if (ModelState.IsValid)
            {
                _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
                _context.PostEmployeeItem(item);
                return new JsonResult(item) { StatusCode = 200 };
            }
            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        //PUT: api/User/{id}
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<EmployeeItem>> UpdateEmployeeItem(int id, [FromBody] EmployeeItem item)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            List<EmployeeItem> existItem = new List<EmployeeItem>(_context.GetEmployee(id));

            try
            {
                if (id != item.id)
                {
                    return BadRequest();
                }

                else if (!existItem.Any())
                {
                    return NotFound();
                }
                else
                {
                    _context.UpdateEmployeeItem(id, item);
                    return new JsonResult(item) { StatusCode = 200 };
                }
            }

            catch (Exception e)
            {
                return new JsonResult(e) { StatusCode = 500 };
            }

        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<EmployeeItem>> DeleteEmployeeItem(int id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            List<EmployeeItem> existItem = new List<EmployeeItem>(_context.GetEmployee(id));

            try
            {
                if (!existItem.Any())
                {
                    return NotFound();
                }
                else
                {
                    _context.DeleteEmployeeItem(id);
                    return new JsonResult("Success delete "+id) { StatusCode = 200 };
                }
            }

            catch (Exception e)
            {
                return new JsonResult(e) { StatusCode = 500 };
            }

        }


        // GET: api/user/{id}
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems(int id)
        {

            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            List<EmployeeItem> existItem = new List<EmployeeItem>(_context.GetEmployee(id));
            if (!existItem.Any())
            {
                return NotFound();
            }
            else
            {
                return new JsonResult(_context.GetEmployee(id)) { StatusCode = 200 };
            }
        }
    }
}
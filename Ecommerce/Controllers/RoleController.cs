using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly EcommerceDataContext _context;

        public RoleController(EcommerceDataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var roles = _context.Roles.ToList();
            return Ok(roles);
        }

        [HttpPost]
        public ActionResult Create([FromBody] Role role)
        {
            if (role == null)
            {
                return BadRequest();
            }

            Role roleToUpdate = new Role
            {
                RoleName = role.RoleName
            };

            _context.Roles.Add(roleToUpdate);
            _context.SaveChanges();

            return Ok("Yes Update");

        }
    }
}
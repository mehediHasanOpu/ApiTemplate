using Core.Models;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("category-menu")]
        public IList<Categories> CategoryMenu()
        {
            return (_context.Categories.Where(a=>a.Level == 0).OrderByDescending(a=>a.Order_level).Take(11).ToList());
        }
    }
}

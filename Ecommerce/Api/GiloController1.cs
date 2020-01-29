using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecommerce.Api
{
    [Route("api/[controller]")]
    public class GiloController1 : Controller
    {
        private readonly Ecommerce.Data.ApplicationDbContext _context;

        public GiloController1(Ecommerce.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("MainCategoryById")]
        public IActionResult GetMainCategoryById([FromQuery]int id)
        {
            var maincategory = _context.MainCategories.FirstOrDefault(x => x.Id == id);
            if (maincategory != null)
            {
                return Ok(maincategory);

            }
            else
            {
                return NotFound("No record Found");
            };
            //return $"your name is {name} and ur ID is : {id}";
        }

        [HttpGet("SubCategoryById")]
        public IActionResult GetSubCategoryById([FromQuery]int id)
        {
            var subcategory = _context.SubCategories.FirstOrDefault(x => x.Id == id);
            if (subcategory != null)
            {
                return Ok(subcategory);

            }
            else
            {
                return NotFound("No record Found");
            };
            //return $"your name is {name} and ur ID is : {id}";
        }


        [HttpGet("MainCategoryALL")]
        public List<MainCategory> MainCategories()
        {
            var maincategory = _context.MainCategories.ToList();
            
            return maincategory;

        }

        [HttpGet("SubCategoryALL")]
        public List<SubCategory> subCategories()
        {
            var subcategories = _context.SubCategories.ToList();

            return subcategories;

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

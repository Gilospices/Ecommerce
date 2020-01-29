using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecommerce.Api
{
    public class Valuesviewmodel
    {
        public string ActualAddress { get; set; }
    }

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("ByName")]
        public string Get([FromQuery]int id, [FromQuery] string name)
        {

            return $"your name is {name} and ur ID is : {id}";
        }


        [HttpGet("AddressById")]
        public IActionResult GetAddressById([FromQuery]int id)
        {
            var listofaddrsss = new List<Address>
            {
                new Address
                {
                    Id=1,
                    ActualAddress=" no 5 john",
                },
                new Address
                {
                    Id=2,
                    ActualAddress=" no 6 mushin",
                },
                 new Address
                {
                    Id=2,
                    ActualAddress=" no 10 oshodi",
                },
            };


            var requestedaddress = listofaddrsss.FirstOrDefault(x => x.Id == id);
            if (requestedaddress!=null)
            {
            return Ok(requestedaddress);

            }
            else
            {
                return NotFound("No record Found");
             };
            //return $"your name is {name} and ur ID is : {id}";
        }


        //[HttpGet("AddressByAll")]
        //public IActionResult GetAddressById([FromQuery]int id)
        //{
        //    var listofaddrsss = new List<Address>
        //    {
        //        new Address
        //        {
        //            Id=1,
        //            ActualAddress=" no 5 john",
        //        },
        //        new Address
        //        {
        //            Id=2,
        //            ActualAddress=" no 6 mushin",
        //        },
        //         new Address
        //        {
        //            Id=3,
        //            ActualAddress=" no 10 oshodi",
        //        },
        //    };


        //    var data = listofaddrsss.Select(x => new Valuesviewmodel { ActualAddress = x.ActualAddress }).ToList();

        //    return Ok( data);
        //    //return $"your name is {name} and ur ID is : {id}";
        //}

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

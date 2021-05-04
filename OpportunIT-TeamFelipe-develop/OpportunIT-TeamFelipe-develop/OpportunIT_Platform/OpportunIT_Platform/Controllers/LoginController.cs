using Microsoft.AspNetCore.Mvc;
using OpportunIT_Platform.Context;
using OpportunIT_Platform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OpportunIT_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private  AppDbContext context;

        public LoginController(AppDbContext context)
        {
            this.context = context;

        }
        // GET: api/<LoginController>
        [HttpGet]
        public Login Get()
        {
            


            using(var database = context)
            {

                var query = (from login in database.Login
                             select login);

                return query.FirstOrDefault();

            }
           
        }

        // GET api/<LoginController>/5
        [HttpGet("{id}")]
        public Login Get(int id)
        {
            var login = context.Login.FirstOrDefault(l=>l.IdLogin == id);
            return login;
        }

        // POST api/<LoginController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

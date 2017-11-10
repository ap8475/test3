using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pivotal.Extensions.Configuration.ConfigServer;
using Microsoft.Extensions.Configuration;

namespace AppModWebApi.Controllers
{
    [Route("/[controller]")]
    public class ValuesController : Controller
    {
		private IConfigurationRoot Config { get; set; }
		public ValuesController(IConfigurationRoot config)
        {
            Config = config;
        }
		public IActionResult ConfigServer()
        {
            ViewData["TestApp"] = Config["TestApp"];
            return View();
        }
         // GET api/values/5
        [HttpGet()]
        public string Get()
        {
           
            return "Hello From PCF="+@ViewData["TestApp"];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

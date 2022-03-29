using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPI_RESTFul_Core_Omar.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values  Obtener
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5 Obtener
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values  Crear
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5 Actualizar
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5 Borrar
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoAPI_RESTFul_Core_Omar.Contexts; //** Para utilizar AppDbContext
using DemoAPI_RESTFul_Core_Omar.Entities; //** Para utilizar Proveedor en IEnumerable
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPI_RESTFul_Core_Omar.Controllers
{
    [Route("api/[controller]")]
    public class ProveedorController : Controller
    {
        //Crea e inicializa Fiel context
        private readonly AppDbContext context;

        //** Generar el constructor del controlador
        //a través de este realiza la inyección de dependencias que utiliza Core
        //inyectando nuestra clase Context en el constructor, así se podrána hacer uso de todas las dependencias dentro del controlador (Entity)
        public ProveedorController(AppDbContext context)
        {
            //Crea e inicializa Fiel context
            this.context = context;
        }

        // GET: api/values  Obtener
        [HttpGet]
        public IEnumerable<Proveedor> Get()
        {
            return context.Proveedor.ToList(); //Obtiene los datos de la tabla en formato Json
        }

        // GET api/values/5 Obtener
        [HttpGet("{id}")]
        public Proveedor Get(string id) //El campo es de tipo cadena
        {
            var proveedor = context.Proveedor.FirstOrDefault(p => p.clave == id);
            return proveedor;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

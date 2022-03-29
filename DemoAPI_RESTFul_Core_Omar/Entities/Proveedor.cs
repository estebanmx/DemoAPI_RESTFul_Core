using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace DemoAPI_RESTFul_Core_Omar.Entities
{
    public class Proveedor
    {   [Key]
        public string clave         { get; set; }
        public string nombre        { get; set; }
        public string descripcion   { get; set; }
        public int    activo        { get; set; }
    }
}

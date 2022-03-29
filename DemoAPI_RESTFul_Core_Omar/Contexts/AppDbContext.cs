using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore; //** Instalar desde Manage NuGet Packages: Microsoft.EntityFrameworkCore v5.0
using DemoAPI_RESTFul_Core_Omar.Entities; //** Para usar Proveedor en DbSet

namespace DemoAPI_RESTFul_Core_Omar.Contexts
{   //Heredar de clase DbContext
    public class AppDbContext:DbContext
    {   //** Pasar las caracterìsticas de Context hacia la clase base DbContext de EntityFramework 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        //** Especificar las tablas que formarán parte de nuestro Context
        //** Especificar dentro de esta (DbSet) nuestra entidad, nombrarla como nuestra tabla producto
        public DbSet<Proveedor> Proveedor { get; set; }

        //** En caso de trabajar mas tablas, agregar una nueva entidad
    
    }
}

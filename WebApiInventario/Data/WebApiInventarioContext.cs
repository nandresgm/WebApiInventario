using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiInventario.Models;

namespace WebApiInventario.Data
{
    public class WebApiInventarioContext : DbContext
    {
        public WebApiInventarioContext (DbContextOptions<WebApiInventarioContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiInventario.Models.Inventario> Inventario { get; set; } = default!;
    }
}

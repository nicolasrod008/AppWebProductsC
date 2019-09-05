using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppWebProductsC.Models;

    public class AppWebProductsCContext : DbContext
    {
        public AppWebProductsCContext (DbContextOptions<AppWebProductsCContext> options)
            : base(options)
        {
        }

        public DbSet<AppWebProductsC.Models.Categoria> Categoria { get; set; }

        public DbSet<AppWebProductsC.Models.Producto> Producto { get; set; }
    }

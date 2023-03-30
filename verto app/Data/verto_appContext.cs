using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using verto_app.Models;

namespace verto_app.Data
{
    public class verto_appContext : DbContext
    {
        public verto_appContext (DbContextOptions<verto_appContext> options)
            : base(options)
        {
        }

        public DbSet<verto_app.Models.Photo> Photo { get; set; } = default!;
    }
}

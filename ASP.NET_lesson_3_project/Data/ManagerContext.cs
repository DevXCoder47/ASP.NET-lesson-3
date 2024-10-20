using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NET_lesson_3_project.Models;

namespace ASP.NET_lesson_3_project.Data
{
    public class ManagerContext : DbContext
    {
        public ManagerContext (DbContextOptions<ManagerContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ASP.NET_lesson_3_project.Models.Worker> Worker { get; set; } = default!;
    }
}

using Microsoft.EntityFrameworkCore;
using MoviesBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesBackend.DBContexts
{
    public class MyDBContexts : DbContext
    {
        public MyDBContexts(DbContextOptions<MyDBContexts> options)
           : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }

    }
}

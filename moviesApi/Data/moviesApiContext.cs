using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moviesApi.Models;

namespace moviesApi.Data
{
    public class moviesApiContext : DbContext
    {
        public moviesApiContext (DbContextOptions<moviesApiContext> options)
            : base(options)
        {
        }

        public DbSet<moviesApi.Models.Movie> Movie { get; set; }
    }
}

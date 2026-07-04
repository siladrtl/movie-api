using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApi.Domain.Entities;

namespace MovieApi.Persistence.Context
{
    public class MovieApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //sql bağlantı adresini yazan metot
        {
            optionsBuilder.UseSqlServer("Server=siladertli\\SQLEXPRESS; Initial Catalog= ApiMovieDb; integrated Security=true; TrustServerCertificate=true;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}

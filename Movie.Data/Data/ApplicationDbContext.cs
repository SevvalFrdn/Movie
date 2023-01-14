using Microsoft.EntityFrameworkCore;
using Movie.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Data.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Celebtiry> Celebtiries { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Moviee> Movies { get; set; }
        public DbSet<Studio> Studios { get; set; }


    }
}

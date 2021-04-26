using CORE.Entities.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
   public class UniAppContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Bağlantı yeri önemli doğru girmeliydik
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=UniApp;Trusted_Connection=true");
        }

        public DbSet<Comment> Comments { get; set; }

        internal void AttachTo(string v, Post post)
        {
            throw new NotImplementedException();
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Univercity> Univercities { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<UnivercityImage> univercityImages { get; set; }
        public DbSet<UserFollow> UserFollows { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

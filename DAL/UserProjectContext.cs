using codechallenge.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace codechallenge.DAL
{
    public class UserProjectContext : DbContext
    {
        public UserProjectContext() : base("UserProjectContext")
        {

        }

        public DbSet<tbUser> tbUser { get; set; }
        public DbSet<tbProject> tbProject { get; set; }
        public DbSet<tbUserProject> tbUserProject { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}
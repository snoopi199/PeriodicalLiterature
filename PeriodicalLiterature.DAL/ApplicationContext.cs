using Microsoft.AspNet.Identity.EntityFramework;
using PeriodicalLiterature.Models.Entity;
using PeriodicalLiterature.Models.AuthorizationOfModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PeriodicalLiterature.Models.Entity.Role;

namespace PeriodicalLiterature.DAL
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("ApplicationContextDb") { }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Boss> Bosses { get; set; }

        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Comment> Comments { get; set; }


       
    }
}
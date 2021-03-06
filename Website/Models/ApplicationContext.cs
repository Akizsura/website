﻿using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Website.Models;

namespace Website
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("IdentityDb") { }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
    }
}

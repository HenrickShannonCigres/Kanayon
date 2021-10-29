using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FinalProjUI.Models;

namespace FinalProjUI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            : base(options)
        { 
        }
        //public DbSet<FinalProjUI> FinalProjUIs { get; set; }
        //creating an entity model week4
    }
}

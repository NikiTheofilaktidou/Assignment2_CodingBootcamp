using NikiTheofilaktidou_assignment_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NikiTheofilaktidou_assignment_2.MyDatabase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("link")
        {

        }
        public DbSet<Trainer> Trainers { get; set; }
    }
}
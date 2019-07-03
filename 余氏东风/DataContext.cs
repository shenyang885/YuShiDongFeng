using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WalkingTec.Mvvm.Core;
using 余氏东风.Models;

namespace 余氏东风
{
    public class DataContext : FrameworkContext
    {
        public DbSet<School> Schools { get; set; }
        public DataContext(string cs, DBTypeEnum dbtype)
             : base(cs, dbtype)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<School>().HasKey(p => p.ID);
        }

    }
}

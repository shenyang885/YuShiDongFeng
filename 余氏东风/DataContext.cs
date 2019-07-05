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
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShopCensus> ShopCensus { get; set; }
        public DataContext(string cs, DBTypeEnum dbtype)
             : base(cs, dbtype)
        {
        }
    }
}

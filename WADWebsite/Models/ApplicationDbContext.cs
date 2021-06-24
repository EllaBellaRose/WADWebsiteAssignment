using System;
//using System.Collections.Generic;
//using System.Linq;
using Microsoft.EntityFrameworkCore;
//using System.Threading.Tasks;

namespace WADWebsite.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<Festival> Festivals { get; set; }
        //public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}


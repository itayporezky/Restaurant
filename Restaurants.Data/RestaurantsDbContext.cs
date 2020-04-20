using Microsoft.EntityFrameworkCore;
using Restuarants.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurants.Data
{
    public class RestaurantsDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}

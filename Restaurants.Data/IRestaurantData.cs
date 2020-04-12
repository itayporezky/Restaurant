using Restuarants.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Restaurants.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);

    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Number 1", Location = "Rishon", Cuisine = CuisineType.Indian },
                new Restaurant { Id = 2, Name = "Dud 5", Location = "Tel aviv", Cuisine = CuisineType.Mexican },
                new Restaurant { Id = 3, Name = "Yoon 12", Location = "Ramla", Cuisine = CuisineType.Italian }
            };
        }
        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}

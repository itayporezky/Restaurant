using Restuarants.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Restaurants.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();

    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Number 1", Location = "Rishon", Cuisine = CuisineType.Indian },
                new Restaurant { Id = 2, Name = "Number 2", Location = "Tel aviv", Cuisine = CuisineType.Mexican },
                new Restaurant { Id = 3, Name = "Number 3", Location = "Ramla", Cuisine = CuisineType.Italian }
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}

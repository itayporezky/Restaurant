using Bite.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bite.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
        Restaurant Add(Restaurant newRestaurant);
        Restaurant Update(Restaurant updatedRestaurant);
        Restaurant Delete(int id);
        int GetCountOfRestaurants();

        int Commit();
    }
}

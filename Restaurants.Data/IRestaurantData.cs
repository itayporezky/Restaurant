using Restuarants.Core;
using System.Collections.Generic;
using System.Text;

namespace Restaurants.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
        Restaurant Add(Restaurant newRestaurant);
        Restaurant Update(Restaurant updatedRestaurant);
        Restaurant Delete(int id);
        int Commit();
    }



}

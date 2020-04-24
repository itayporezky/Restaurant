using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bite.Core;
using Bite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Bite.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        public readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;

        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public ListModel(IConfiguration config,
                         IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }
        public void OnGet()
        {

            Message = "Hello";
            Restaurants = restaurantData.GetRestaurantsByName(SearchTerm);
        }
    }
}

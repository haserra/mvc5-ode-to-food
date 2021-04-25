using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        // private field to the class
        List<Restaurant> restaurants;
        
        // This represents in memory data base
        //hardcoding the dependency is wrong. Let's use Dependency Injection instead
        public InMemoryRestaurantData()
        {
            // this defines an in memory 
            this.restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "Scott's Pizza", Cuisine = CuisineType.Italian},
                new Restaurant {Id = 2, Name = "Tersiguels", Cuisine = CuisineType.French},
                new Restaurant {Id = 3, Name = "Mango Grove", Cuisine = CuisineType.Indian}
            };
        }

        public Restaurant Get(int id)
        {
            //throw new NotImplementedException();
            return this.restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            //throw new NotImplementedException();
            // using the extension method over the list
            return this.restaurants.OrderBy(r => r.Name);

        }
    }
}

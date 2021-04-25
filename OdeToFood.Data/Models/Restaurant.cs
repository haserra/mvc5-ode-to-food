using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        // describe the entity and its properties ()
        // this class is public, by default is private
        public int Id { get; set; }
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
        

    }
}

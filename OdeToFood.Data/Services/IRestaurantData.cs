using OdeToFood.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll(); // Give me a list of all restaurants that are on my data source, whatever it is
        Restaurant Get(int id); // Give me a single Restaurant that is identified by the id Id
    }
}

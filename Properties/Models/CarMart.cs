using CarListApp.Maui.Properties.Models;

namespace CarListApp.Maui.Properties.Models
{
    public class CarMart
        { public int Id { get; set; }

        public  List <Car> Cars { get; set; } = new List<Car>();
    }
}


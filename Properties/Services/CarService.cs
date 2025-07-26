using Android.AdServices.AdIds;
using CarListApp.Maui.Properties.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Android.Graphics.ColorSpace;

namespace CarListApp.Maui.Properties.Services
{
    internal class CarService
    {
     public List <Car> GetCars()

        {
            return new List<Car>()

            {
                new Car
                {
                Id = 1, Make = "Honda", Model = "Fit", Vin= "123"
                },
                new Car
                {
                Id = 1, Make = "Honda", Model = "Fit", Vin= "124"
                },
                new Car
                {
                Id = 1, Make = "Honda"  , Model = "Fit" , Vin= "125"
                 },
            };
        }
    }
}

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetCarByBrandId();


            //   GetCarDetails();

            // CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add{ };

            //   ColorAdd();
            // ColorGetById();
            //colorManager.Delete(new Color { ColorId = 11, ColorName = "Yeşil" });

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result=customerManager.Add(new Customer { Id=1, UserId=2, CompanyName="ABC A.Ş."});

        }

        private static void ColorGetById()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetByColorId(11);

            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ColorId + "/ " + item.ColorName);

                }

            }
        }

        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Add(new Color { ColorId = 11, ColorName = "Yeşil" });
        }

        private static void GetCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Id + "  " + car.Description + "   " + car.ColorName+" "+car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarByBrandId()
           {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarsByBrandId(1);
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.Description);

            }
        }
    }
}

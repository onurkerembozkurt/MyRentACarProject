using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;
using System;

namespace Console
{
   public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.BrandId = 14;
            car.CarId = 14;
            car.ColorId = 14;
            car.DailyPrice = 20004;
            car.ModelYear = 20014;
            car.Description = "Skoda";
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car);
            foreach (var item in carManager.GetAll())
            {
                System.Console.WriteLine(item.Description);
            }
        }
    }
}

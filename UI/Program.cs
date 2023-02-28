using Business.Concrete;
using Core.Utilities;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;
using System;
using System.Collections.Generic;

namespace Console
{
   public class Program
    {
        static void Main(string[] args)
        {
            BrandTest();
            ColorTest();
            CarTest();

        }

        private static void BrandTest()
        {
            Brand brand1 = new Brand();
            brand1.BrandId = 1;
            brand1.BrandName = "BMW";
            Brand brand2 = new Brand { BrandId = 2, BrandName = "Renault" };
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            System.Console.WriteLine(brandManager.Add(brand1).Success);
            System.Console.WriteLine(brandManager.Add(brand2).Success);
        }

        private static void ColorTest()
        {
            Color color1 = new Color { ColorId = 1, ColorName = "Red" };
            Color color2 = new Color { ColorId = 2, ColorName = "Blue" };
            ColorManager colorManager = new ColorManager(new EfColorDal());
            System.Console.WriteLine(colorManager.Add(color1).Message);
            System.Console.WriteLine(colorManager.Add(color2).Message);
            foreach (var color in colorManager.GetAll().Data)
            {
                System.Console.WriteLine(colorManager.GetById(1));
            }

        }

        private static void CarTest()
        {
            Car car1 = new Car { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 2500, Description = "X4", ModelYear = 2002 };
            Car car2 = new Car { CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 4000, Description = "Megane", ModelYear = 2001 };
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car1);
            carManager.Add(car2);

            //I DONT WANT TO ADD, UPDATE AND DELETE METHOD CURRENTLY
            foreach (var car in carManager.GetAll().Data)
            {
                System.Console.WriteLine(carManager.GetAll().Data);
            }
        }
    }
}

using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;
        public InMemoryCarDal()
        {
            cars = new List<Car>() {
            new Car(){ BrandId=1, ColorId=1,DailyPrice=1555,CarId=1,ModelYear=2020,Description="BMW" },
            new Car(){ BrandId=1, ColorId=1,DailyPrice=1235,CarId=2,ModelYear=2019 ,Description="Renault"},
            new Car(){ BrandId=1, ColorId=1,DailyPrice=1606,CarId=3,ModelYear=2018,Description="Fiat" },

            };
        }

        public void Add(Car car)
        {
            cars.Add(car);
            
        }

        public void Delete(Car car)
        {
            Car CarToDelete = null;
            foreach (var item in cars)
            {
                if (car.CarId==item.CarId)
                {
                    CarToDelete = item;
                }
            }
            cars.Remove(CarToDelete);



        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetByCarId(int carId)
        {
            return cars.FirstOrDefault(c=>c.CarId==carId);
           
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car toUpdateCar = null;
            foreach (var item in cars)
            {
                if (item.CarId==car.CarId)
                {
                    toUpdateCar.CarId = car.CarId;
                    toUpdateCar.BrandId = car.BrandId;
                    toUpdateCar.DailyPrice = car.DailyPrice;
                    toUpdateCar.ModelYear = car.ModelYear;
                    toUpdateCar.ColorId = car.ColorId;
                    toUpdateCar.Description = car.Description;
                }
            }
        }
    }
}

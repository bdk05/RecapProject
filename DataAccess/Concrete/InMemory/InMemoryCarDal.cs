using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
       {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
          /*     new Car { Id=1, BrandId=1, ColorId=3, SetModelYear(2010), DailyPrice=200, Description="Jeep" },
               new Car { Id=2, BrandId=2, ColorId=2, SetModelYear(2020), DailyPrice=80, Description="Pikap" },
               new Car { Id=3, BrandId=3, ColorId=1, SetModelYear(2021), DailyPrice=500, Description="Mercedes" },
               new Car { Id=5, BrandId=1, ColorId=5, SetModelYear(1999), DailyPrice=70, Description="Jeep" },
               new Car { Id=4, BrandId=4, ColorId=2, SetModelYear(2018), DailyPrice=100, Description="Renault" },
               new Car { Id=6, BrandId=3, ColorId=1, SetModelYear(2018), DailyPrice=300, Description="Mercedes" },
*/
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;

            carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByID(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;

            carToUpdate = _cars.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
           // carToUpdate.SetModelYear(car.GetModelYear());
            carToUpdate.Description = car.Description;

        }

       
    }
}

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
        List<Car> cars;
        public InMemoryCarDal()
        {
            cars = new List<Car> 
            { 
                new Car
                {
                    Id=1,
                    BrandId=1,
                    ModelYear=2020,
                    ColorId=1,
                    DailyPrice=1500,
                    Description="Audi"
                },
                
                new Car
                {
                    Id=2,
                    BrandId=2,
                    ModelYear=2021,
                    ColorId=2,
                    DailyPrice=2000,
                    Description="Mercedes"
                }
            };
        }
        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = cars.SingleOrDefault(p=>p.Id==car.Id);
            cars.Remove(carToDelete);
            
        }

        public Car Get(Expression<Func<Car, bool>> filter)
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

        public List<CarDetailDto> GetAllWithDetail()
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            Car carById = cars.SingleOrDefault(p=>p.Id==id);
            return carById;
        }

        public void Update(Car car)
        {
            Car carToUpdate = cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate = car;
        }

        List<CarDetailDto> ICarDal.GetAllWithDetail()
        {
            throw new NotImplementedException();
        }
    }
}

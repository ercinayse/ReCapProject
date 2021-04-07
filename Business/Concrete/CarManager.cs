using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            if (car.Name.Length >= 2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Car's name must be at least 2 character and daily price must be bigger than 0"); 
                   
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
           return _carDal.GetAll();
        }

        public List<CarDetailDto> GetAllWithDetail()
        {
            return _carDal.GetAllWithDetail();
        }

        public Car GetById(int id)
        {
            return _carDal.Get(p=>p.Id==id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}

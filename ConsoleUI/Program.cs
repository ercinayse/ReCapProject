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
            Car sample = new Car 
            { 
                Id=3,
                BrandId=1,
                ModelYear=2018,
                ColorId=1,
                DailyPrice=1000,
                Description="Toyota"
            };
            EfCarDal efCarDal = new EfCarDal();

            CarManager carManager = new CarManager(efCarDal);

            
            var carSample=carManager.GetById(1);
            Console.WriteLine(carSample.DailyPrice);
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
            
            Console.Read();


        }
    }
}

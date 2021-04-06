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

            InMemoryCarDal inMemoryCar = new InMemoryCarDal();
            inMemoryCar.Add(sample);
            inMemoryCar.GetAll();
            inMemoryCar.GetById(1);
            
            sample.DailyPrice = 800;
            inMemoryCar.Update(sample);
            inMemoryCar.Delete(sample);
            Console.Read();


        }
    }
}

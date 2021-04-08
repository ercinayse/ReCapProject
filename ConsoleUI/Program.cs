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
            
            EfCarDal efCarDal = new EfCarDal();
            
            CarManager carManager = new CarManager(efCarDal);
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            
            colorManager.Update(new Color { Id = 7, Name = "Beyaz" });
            //colorManager.Update(new Color { Id = 1, Name = "siyah" });
            //colorManager.Delete(new Color { Id = 2, Name = "Red" });
            foreach (var item in colorManager.GetAll().Data)
            {
                Console.WriteLine(item.Name);
                
            }
            Console.WriteLine(colorManager.GetAll().Message);
            colorManager.GetById(1);
            Console.WriteLine("------Detail-----");

            foreach (var item in carManager.GetAllWithDetail().Data)
            {
                Console.WriteLine(item.BrandName +"/"+item.CarName+"/"+item.ColorName+"/"+item.DailyPrice);
            }
            Console.Read();


        }
    }
}

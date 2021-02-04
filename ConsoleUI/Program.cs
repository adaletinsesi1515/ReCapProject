using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine(item.DailyPrice); 
            //}

            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car();
            //car.Id = 11;
            car.BrandId = 5;
            car.ColorId = 3;
            car.DailyPrice = 0;
            car.ModelYear = 1996;
            car.Description = "Test";
            carManager.Add(car);

            BrandManager ekle = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();
            brand.BrandName = "T";
            ekle.Add(brand);



        }
    }
}

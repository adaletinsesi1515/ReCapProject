using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _Car;
        List<Brand> _Brand;
        List<Color> _Color;
        public InMemoryCarDal()
        {
            _Car = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear=1990, DailyPrice=10, Description="1990 model araç"},
                new Car{Id=2, BrandId=1, ColorId=2, ModelYear=1995, DailyPrice=7, Description="1995 model araç"},
                new Car{Id=3, BrandId=2, ColorId=3, ModelYear=1998, DailyPrice=5, Description="1998 model araç"},
                new Car{Id=4, BrandId=2, ColorId=4, ModelYear=1999, DailyPrice=4, Description="1999 model araç"},
                new Car{Id=5, BrandId=3, ColorId=5, ModelYear=1990, DailyPrice=1, Description="1990 model araç"},
            };

            _Brand = new List<Brand>
            {
                new Brand{BrandId=1, BrandName="Renault"},
                new Brand{BrandId=2, BrandName="Toyota"},
                new Brand{BrandId=3, BrandName="Ford"},
            };

            _Color = new List<Color>
            {
                new Color{ColorId=1, ColorName="Lacivert"},
                new Color{ColorId=2, ColorName="Beyaz"},
                new Color{ColorId=3, ColorName="Sarı"},
                new Color{ColorId=4, ColorName="Kırmızı"},
                new Color{ColorId=5, ColorName="Gri"}

            };



        }
        public void Add(Car car)
        {
            _Car.Add(car);
            Console.WriteLine("Araç eklendi");
        }

        public void Delete(Car car)
        {
            Car carDelete = _Car.SingleOrDefault(p => p.Id == car.Id);
            _Car.Remove(carDelete);
            Console.WriteLine("Araç silindi");
        }

        public List<Car> GetAll()
        {
            return _Car;
        }

        public List<Car> GetAllByBrand(int BrandId)
        {
            return _Car.Where(p => p.BrandId == BrandId).ToList();
        }

        public List<Car> GetAllByColor(int ColorId)
        {
            return _Car.Where(p=>p.ColorId == ColorId).ToList();
        }

        public void Update(Car car)
        {
            Car CarUpdate = _Car.SingleOrDefault(p=>p.Id == car.Id);
            CarUpdate.BrandId = car.BrandId;
            CarUpdate.ColorId = car.ColorId;
            CarUpdate.DailyPrice = car.DailyPrice;
            CarUpdate.ModelYear = car.ModelYear;
            CarUpdate.Description = car.Description;
            Console.WriteLine("Araç kaydı güncellendi");
        }
    }
}

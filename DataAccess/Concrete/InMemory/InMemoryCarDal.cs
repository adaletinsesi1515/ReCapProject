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
        List<Car> _Car;
        
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

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _Car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrand(int BrandId)
        {
            return _Car.Where(p => p.BrandId == BrandId).ToList();
        }

        public List<Car> GetAllByColor(int ColorId)
        {
            return _Car.Where(p=>p.ColorId == ColorId).ToList();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
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

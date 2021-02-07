﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _icarDal;
        
        public CarManager(ICarDal IcarDal)
        {
            _icarDal = IcarDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0)
            {
                _icarDal.Add(car);
            }
            else
            {
                Console.WriteLine("Günlük kiralama ücreti 0 TL olamaz");
            }
                
            
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _icarDal.GetAll();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            return _icarDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _icarDal.GetAll(p => p.BrandId == Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _icarDal.GetAll(p => p.ColorId == Id);
        }

        
    }
}

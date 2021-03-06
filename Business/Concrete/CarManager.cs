﻿using Business.Constant;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcers.Validation;
using FluentValidation;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _icarDal;
        
        public CarManager(ICarDal IcarDal)
        {
            _icarDal = IcarDal;
        }


        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
           

            ValidationTool.Validate(new CarValidator(), car);


            _icarDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
            
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_icarDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_icarDal.GetCarDetails(), Messages.CarListed);
        }

        public IResult Delete(Car car)
        {
            _icarDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IResult Update(Car car)
        {
            _icarDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_icarDal.GetAll(p => p.BrandId == Id), Messages.CarListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_icarDal.GetAll(p => p.ColorId == Id), Messages.CarListed);
        }
    }
}

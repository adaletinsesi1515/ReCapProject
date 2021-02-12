using Business.Constant;
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

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _icarDal;
        
        public CarManager(ICarDal IcarDal)
        {
            _icarDal = IcarDal;
        }



        public IResult Add(Car car)
        {
            if (car.CarName.Length<2)
            {
                return new ErrorResult(false, Messages.CarNameLenght);
                
            }
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

using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
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
        public List<Car> GetAll()
        {
            return _icarDal.GetAll();
        }
    }
}

﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        private object entity;

        public BrandManager(IBrandDal IbrandDal)
        {
            _brandDal = IbrandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length>=2)
            {
                _brandDal.Add(brand);
            }
            else
            {
                Console.WriteLine("Brand Name en az iki karakter olmalıdır");
            }
            
        }

        public void Add()
        {
            throw new NotImplementedException();
        }
    }
}
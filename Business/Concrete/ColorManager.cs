using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ColorList);
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == id));
        }
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);

        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }

        IDataResult<List<System.Drawing.Color>> IColorService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<System.Drawing.Color> IColorService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Add(System.Drawing.Color color)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(System.Drawing.Color color)
        {
            throw new NotImplementedException();
        }

        public IResult Update(System.Drawing.Color color)
        {
            throw new NotImplementedException();
        }
    }
}
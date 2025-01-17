﻿using Core.DataAccess;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        //List<CarDetailDto> GetCarDetails();
        List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null);
    }
}

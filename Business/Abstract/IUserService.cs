﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByUserId(int userId);
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}

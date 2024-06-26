﻿using Core.Entities.Concrete;
using Core.Utilities.Results.DataResult;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Security.JWT;
using Core.Entities.DTOs;
using EntityLayer.DTOs;

namespace BusinessLayer.Abstract;


public interface IAuthService
{
    IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
    IDataResult<User> Login(UserForLoginDto userForLoginDto);
    IResult UserExists(string email);
    IDataResult<AccessToken> CreateAccessToken(User user);
}

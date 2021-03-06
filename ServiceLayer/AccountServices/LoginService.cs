﻿using BizData.Entities;
using BizDbAccess.Authentication;
using BizDbAccess.GenericInterfaces;
using BizLogic.Authentication;
using DataLayer.EfCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer.AccountServices
{
    public class LoginService
    {
        private readonly IUnitOfWork _context;
        private readonly UserDbAccess _dbAccess;

        public LoginService(IUnitOfWork context)
        {
            _context = context;
            _dbAccess = new UserDbAccess(_context);
        }

        public bool LoginUsuario(LoginViewModel lvm)
        {
            _dbAccess.LoginUsuario(lvm.Email, lvm.Password);
            return true;
        }
    }
}

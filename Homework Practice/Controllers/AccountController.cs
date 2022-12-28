﻿using ServiceLayer.Services;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Practice.Controllers
{
    public class AccountController
    {
        public void Login() 
        {
            Console.WriteLine("Add email :");
            string email=Console.ReadLine();

            Console.WriteLine("Add password :");
            string password=Console.ReadLine();

            int roleId = 2;
            IAccountService account = new AccountService();

            string result= account.Login(email, password, roleId);
            Console.WriteLine(result);
        } 

    }
}

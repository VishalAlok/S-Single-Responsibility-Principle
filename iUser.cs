using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility_Principle
{
    interface iUser
    {
        bool login(string name, string password);
        bool Register(string name, string OTP,string EmailID);
    }
    interface ilogged
    {
        bool LogError(string ExceptionMsg);
    }
    interface iEmail
    {
        bool LogError(string ExceptionMsg);
    }
}
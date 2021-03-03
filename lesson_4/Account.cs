using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_4
{
    struct Account
    {
        public string Login, Password;

        public Account(string l, string p)
        {
            this.Login = l;
            this.Password = p;
        }

        public void Print()
        {
            Console.WriteLine($"Логин: {Login}, Пароль: {Password}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace lesson_5
{
    class MyLogin
    {
        string log;
        public MyLogin(string txt)
        {
            this.log = txt;
        }
        /// <summary>
        /// Проверка длины
        /// </summary>
        /// <returns></returns>
        public MyLogin CheckLength()
        { 
            string msg1 = "Некорректный логин: слишком длинный.";
            string msg2 = "Некорректный логин: слишком короткий";
            string msg3 = "Логин корректной длины";

            string message = String.Empty;

            if (this.log.Length > 10)
            {
                message = msg1;
            }
            else
            {
                if (this.log.Length < 2)
                {
                    message = msg2;
                }
                else
                {
                    message = msg3;
                }
            }
            this.MsgToConsole(message);
            return this;
        }
        /// <summary>
        /// Проверка написания
        /// </summary>
        /// <returns></returns>
        public MyLogin CheckSpell()
        {
            string msg1 = "Некорректный логин: начинается с цифры";
            string msg2 = "Некорректный логин: содержит символы, кроме латинских букв и цифр";
            string msg3 = "Логин содержит корректные символы";

            string message = String.Empty;
            int tmp;
            char c;

            if ((int.TryParse(this.log.Substring(0, 1), out tmp)))
            {
                message = msg1;
            }
            else
            {
                for (int i = 0; i < this.log.Length; i++)
                {
                    c = this.log[i];
                    if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                    {
                        message = msg3;
                    }
                    else
                    {
                        message = msg2;
                    }
                }
            }
            this.MsgToConsole(message);
            return this;
        }

        public MyLogin CheckReg()
        {
            Regex logReg = new Regex(@"[A-Za-z0-9]{2,10}");
            string msg1 = "Логин корректный";
            string msg2 = "Логин некорректный";
            string message = String.Empty;

            if (logReg.IsMatch(this.log))
            {
                message = msg1;   
            } 
            else
            {
                message = msg2;
            }
            this.MsgToConsole(message);
            return this;
        }

        /// <summary>
        /// Вывод технического сообщения в консоль
        /// </summary>
        /// <param name="txt">Сообщение</param>
        public void MsgToConsole(string txt)
        {
            Console.WriteLine(txt);
        }
        /// <summary>
        /// Вывод логина в консоль
        /// </summary>
        public void ToConsole()
        {
            Console.WriteLine(this.log);
        }
    }
}

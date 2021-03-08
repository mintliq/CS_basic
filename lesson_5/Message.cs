using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_5
{
    class Message
    {
        string msg = String.Empty;

        /// <summary>
        /// Считывает текст и преобразует в Message
        /// </summary>
        /// <param name="txt">На вход подается текст</param>
        /// <returns></returns>
        public Message(string txt)
        {
            this.msg = txt;
        }
        /// <summary>
        /// Удаляет слова, длина которых больше заданного параметра
        /// </summary>
        /// <param name="l">Максимальная длина слова</param>
        /// <returns></returns>
        public Message DelLong(int l)
        {
            StringBuilder new_msg = new StringBuilder();
            Message n = new Message("");
            for (int i = 0; i < this.ToArray().Length; i++)
            {
                if (this.ToArray()[i].Length < l)
                {
                    new_msg.Append(this.ToArray()[i] + " ");
                }
            }
            n.msg = new_msg.ToString();
            return n;
        }
        /// <summary>
        /// Удаляет слова, оканчивающиеся на заданный символ
        /// </summary>
        /// <param name="del_char">Символ, на который должно оканчиваться слово</param>
        /// <returns></returns>
        public Message DelIfEndsChar(char del_char)
        {
            StringBuilder new_msg = new StringBuilder();
            Message n = new Message("");
            for (int i = 0; i < this.ToArray().Length; i++)
            {
                if (!this.ToArray()[i].EndsWith(del_char))
                {
                    new_msg.Append(this.ToArray()[i] + " ");
                }
            }
            n.msg = new_msg.ToString();
            return n;
        }
        /// <summary>
        /// Возвращает слово с максимальной длиной
        /// </summary>
        /// <returns></returns>
        public Message FindMaxLength()
        {
            StringBuilder new_msg = new StringBuilder();
            Message n = new Message("");
            int maxIndex = 0;
            for (int i = 0; i < this.ToArray().Length; i++)
            {
                if (this.ToArray()[i].Length > this.ToArray()[maxIndex].Length)
                {
                    maxIndex = i;
                }
            }
            new_msg.Append(this.ToArray()[maxIndex]);
            n.msg = new_msg.ToString();
            return n;
        }
        /// <summary>
        /// Возвращает строку, состоящую из строк с максимальной длиной
        /// </summary>
        /// <returns></returns>
        public Message MsgFromMax()
        {
            StringBuilder new_msg = new StringBuilder();
            Message n = new Message("");
            for (int i = 0; i < this.ToArray().Length; i++)
            {
                if (this.ToArray()[i].Length == this.FindMaxLength().ToString().Length)
                {
                    new_msg.Append(this.ToArray()[i] + " ");
                }
            }
            n.msg = new_msg.ToString();
            return n;
        }

        /// <summary>
        /// Возвращает текст сообщения в виде массива слов
        /// </summary>
        /// <returns>Массив слов</returns>
        public string[] ToArray()
        {
            string[] words = this.msg.Split(' ');
            return words;
        }

        /// <summary>
        /// Возвращает текст сообщения
        /// </summary>
        /// <returns>Сообщение</returns>
        public string ToString()
        {
            return this.msg;
        }

        public void ToConsole(string txt)
        {
            Console.WriteLine(txt);
            Console.WriteLine(this.ToString());
            //return this;
        }
    }
}

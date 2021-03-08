using System;


namespace lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task 1 
            
            /*  Создать программу, которая будет проверять корректность ввода логина.
            Корректным логином будет строка от 2 до 10 символов, 
            содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
            а) без использования регулярных выражений;
            б) **с использованием регулярных выражений.*/

            Console.WriteLine("Введите логин для проверки");
            MyLogin log = new MyLogin(Console.ReadLine());

            log.CheckLength().CheckSpell();
            log.CheckReg();

            #endregion



            #region Task 2

            /*Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            а) Вывести только те слова сообщения,  которые содержат не более n букв.
            б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            в) Найти самое длинное слово сообщения.
            г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            */

            Message msg = new Message("Съешь ещё этих мягких булок да выпей же чаю на травах с медком");
            msg.ToConsole("Исходное сообщение: ");
            msg.DelLong(5)
                .ToConsole("Слова, длина которых 5 символов и более были удалены: ");
            msg.DelIfEndsChar('х')
                .ToConsole("Удалены слова, оканчивающиеся на х");
            msg.FindMaxLength()
                .ToConsole("Самое длинное слово сообщения: ");
            msg.MsgFromMax()
                .ToConsole("Сообщение из самых длинных слов исходного сообщения: ");
            Console.ReadLine();

            #endregion

            #region Task 3

            /*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
            Например:
            badc являются перестановкой abcd.*/

            Console.WriteLine("Введите первое слово: ");
            string str1 = Console.ReadLine();

            Console.WriteLine("Введите второе слово: ");
            string str2 = Console.ReadLine();

            if (IsTransposition(str1, str2))
            {
                Console.WriteLine("Строки являются перестановкой");
            }
            else
            {
                Console.WriteLine("Строки не являются перестановкой");
            }

            #endregion

        }

        static bool IsTransposition(string str1, string str2)
        {
            char[] symb1 = new char[str1.Length];
            char[] symb2 = new char[str2.Length];

            for (int i = 0; i < str1.Length; i++)
            {
                symb1[i] = str1[i];
            }
            for (int i = 0; i < str2.Length; i++)
            {
                symb2[i] = str2[i];
            }

            Array.Sort(symb1);
            Array.Sort(symb2);

            for (int i = 0; i < Math.Max(str1.Length, str2.Length); i++)
            {
                if (symb1[i] != symb2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

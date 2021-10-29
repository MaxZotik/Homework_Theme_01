using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Program
    {
        /// <summary>
        /// Главный метод. Точка запуска программы.
        /// </summary>
        /// <param name="args">Параметры запуска</param>
        static void Main(string[] args)
        {

            #region Задание
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.
            #endregion

            #region Задача - 1

            string name;        //Переменная имя
            int age;            //Переменная возраст
            int height;         //Переменная рост
            double history;     //Переменная балл по истории
            double mathematics; //Переменная балл по математике
            double russian;     //Переменная балл по русскому языку
            double average;     //Переменная средний балл по предметам

            //Ввод данных
            Console.Write("Введите имя: ");
            name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите рост: ");
            height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите бал по истории: ");
            history = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите бал по математике: ");
            mathematics = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите бал по русскому языку: ");
            russian = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            #endregion

            #region Задача - 2

            //Подсчет среднего балла по предметам
            average = (history + mathematics + russian) / 3;
            Console.ReadKey();

            #endregion

            #region Задача - 3 и 5

            //Обычный вывод
            string pattern1 = name + " " + age + " " + height + " " + average.ToString("#.#");
            Console.SetCursorPosition((Console.WindowWidth - pattern1.Length) / 2, Console.CursorTop); //Вывод данных в центре консоли
            Console.WriteLine(pattern1);
            Console.ReadKey();
            Console.Clear();

            //форматированный вывод
            string pattern2 = "Имя: {0} Возраст: {1} Рост: {2} Средний бал по предметам: {3}";
            Console.SetCursorPosition((Console.WindowWidth - pattern2.Length) / 2, Console.CursorTop); //Вывод данных в центре консоли
            Console.WriteLine(pattern2,
                              name,
                              age,
                              height,
                              average.ToString("#.#"));
            Console.ReadKey();
            Console.Clear();

            //Использование интерполяции строк
            string pattern3 = $"Имя: {name} Возраст: {age} Рост: {height} Средний бал по предметам: {average.ToString("#.#")}";
            Console.SetCursorPosition((Console.WindowWidth - pattern3.Length) / 2, Console.CursorTop); //Вывод данных в центре консоли
            Console.WriteLine(pattern3);
            Console.ReadKey();

            #endregion
       }
    }
}

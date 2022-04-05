using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_HomeWork_1_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("---- Урок 2, проект № 1 : задания №№ 1, 2, 5 ----");

            //Решение задания № 1
            Console.WriteLine(); Console.WriteLine("Задание № 1");
            Console.Write("Введите минимальную температуру за сутки, градус Цельсия = ");
            double minTemp = Convert.ToDouble(Console.ReadLine().Replace('.', ',')); //считывание минимальной температуры
            Console.Write("Введите максимальную температуру за сутки, градус Цельсия = ");
            double maxTemp = Convert.ToDouble(Console.ReadLine().Replace('.', ',')); //считывание максимальной температуры 
            double avTemp = 0.5 * (minTemp + maxTemp);                               //вычисление среднего значения
            Console.WriteLine($"Среднесуточная температура равна {avTemp} градусов Цельсия");

            //Решение задания № 2
            Console.WriteLine(); Console.WriteLine("Задание № 2");
            //запрос у пользователя номера месяца с проверкой на корректность ввода
            int nMonth;
            do
            {
                Console.Write("Введите номер месяца (целое число от 1 до 12): ");
                nMonth = Convert.ToInt32(Console.ReadLine());
                if (nMonth >= 1 && nMonth <= 12)
                    break;
                else
                    Console.WriteLine($"Месяц с номером {nMonth} в году отсутствует! Введите номер повторно!"); ;
            }
            while (true);
            //определение названия месяца по его номеру
            string sMonth = "";
            switch (nMonth)
            {
                case 1: sMonth = "Январь"; break;
                case 2: sMonth = "Февраль"; break;
                case 3: sMonth = "Март"; break;
                case 4: sMonth = "Апрель"; break;
                case 5: sMonth = "Май"; break;
                case 6: sMonth = "Июнь"; break;
                case 7: sMonth = "Июль"; break;
                case 8: sMonth = "Август"; break;
                case 9: sMonth = "Сентябрь"; break;
                case 10: sMonth = "Октябрь"; break;
                case 11: sMonth = "Ноябрь"; break;
                case 12: sMonth = "Декабрь"; break;
            }
            Console.WriteLine(sMonth);

            //Решение задания № 5
            Console.WriteLine(); Console.WriteLine("Задание № 5");
            if (avTemp > 0.0 && (nMonth == 1 || nMonth == 2 || nMonth == 12))
                Console.WriteLine("Дождливая зима");
            else
                Console.WriteLine("Вывода результата заданием № 5 не предусмотрено!");

            //
            Console.ReadLine();
        }
    }
}

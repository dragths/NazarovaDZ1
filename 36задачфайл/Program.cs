using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36задачфайл
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("1 Задание");
            double e = Math.E;
            Console.WriteLine($"{e:F1}");*/

            /* Console.WriteLine("2 Задание");
            Console.WriteLine("50\n10");*/

            /* Console.WriteLine("3 Задание");
            Console.WriteLine("50\n10\n5\n0");*/

            /* Console.WriteLine("4 Задание");
            int nomer = Convert.ToInt32(Console.ReadLine());
            nomer = nomer + 10;
            Console.WriteLine(nomer);*/

            /* Console.WriteLine("5 Задание");
            double nomer = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(nomer * 4);*/

            /* Console.WriteLine("6 Задание");
            double r = Convert.ToDouble(Console.ReadLine());
            double p = 3.14;
            Console.WriteLine($"Площадь круга: {p * r * r}");
            Console.WriteLine($"Длина круга: {p * 2 * r}");*/

            /* Console.WriteLine("7 Задание");
            double u = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Косинус {u}: {Math.Cos(u * (Math.PI / 180))}");*/

            /* Console.WriteLine("8 Задание");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            double c = ((b - a) / 2);
            double boc = Math.Sqrt(h * h + c * c);
            Console.WriteLine($"Площадь равнобедренной трапеции = {a + b + 2 * boc}");*/

            /* Console.WriteLine("9 Задание");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            int xstoimost = 10;
            int ystoimost = 20;
            int zstoimost = 30;
            Console.WriteLine(x * xstoimost + y * ystoimost + z * zstoimost);*/

            /*
            Console.WriteLine("10 Задание");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine(@"Мир 
     Труд  
            Май");*/

            /* Console.WriteLine("12 Задание");
            Console.WriteLine("Выберите фигуру: треугольник,четырехугольник,круг");
            string otvet = Console.ReadLine();
            if (otvet == "треугольник")
            {
                Console.WriteLine("Выберите,что хотите посчитать:площадь или периметр");
                string otvet2 = Console.ReadLine();
                if ((otvet2 == "Площадь") || (otvet2 == "площадь"))
                {
                    Console.WriteLine("Введите основание и высоту");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine((1 / 2) * a * h);
                }
                else if ((otvet2 == "Периметр") || (otvet2 == "периметр"))
                {
                    Console.WriteLine("Введите 3 стороны");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double b = Convert.ToDouble(Console.ReadLine());
                    double c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(a + b + c);
                }
            }
            else if (otvet == "Четырехугольник")
            {
                Console.WriteLine("Выберите,что хотите посчитать:площадь или периметр");
                string otvet2 = Console.ReadLine();
                if ((otvet2 == "Площадь") || (otvet2 == "площадь"))
                {
                    Console.WriteLine("Введите основание и высоту");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(a * h);
                }
                else if ((otvet2 == "Периметр") || (otvet2 == "периметр"))
                {
                    Console.WriteLine("Введите 4 стороны");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double b = Convert.ToDouble(Console.ReadLine());
                    double c = Convert.ToDouble(Console.ReadLine());
                    double d = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(a + b + c + d);
                }

            }
            else if ((otvet == "Круг") || (otvet == "круг"))
            {
                Console.WriteLine("Выберите,что хотите посчитать:площадь или длина");
                string otvet2 = Console.ReadLine();
                if ((otvet2 == "Площадь") || (otvet2 == "площадь"))
                {
                    Console.WriteLine("Введите радиус");
                    double r = Convert.ToDouble(Console.ReadLine());
                    double p = 3.14;
                    Console.WriteLine(p * r * r);
                }
                else if ((otvet2 == "Длина") || (otvet2 == "длина"))
                {
                    Console.WriteLine("Введите радиус");
                    double r = Convert.ToDouble(Console.ReadLine());
                    double p = 3.14;
                    Console.WriteLine(2 * p * r);

                }

            }*/

            /* Console.WriteLine("13 Задание");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {a}");*/

            /* Console.WriteLine("14 Задание");
            Console.WriteLine("2 кг\n13 17");*/

            /* Console.WriteLine("15 Задание");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}\n{b}\n{c}\n{d}");*/

            /* Console.WriteLine("16 Задание");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Нет корней");


            }
            else if (d == 0)
            {
                Console.WriteLine($"Квадратное уравнение имеет 1 корень: {-b / (2 * a)}");
            }
            else
            {
                Console.WriteLine($"Квадратное уравнение имеет 2 корня: {(-b + Math.Sqrt(d)) / (2 * a)} и {(-b - Math.Sqrt(d)) / (2 * a)}");
            }*/

            /* Console.WriteLine("17 Задание");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Среднее арифметическое:{((a + b) / 2)}");
            Console.WriteLine($"Среднее геомтерическое:{Math.Sqrt(a*b)}");*/

            /*  Console.WriteLine("18 Задание");
            Console.WriteLine("Введите x1 y1 x2 y2 соответственно");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));*/

            /*  Console.WriteLine("19 Задание");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"a)a={b} b={c} c={a}");
            Console.WriteLine($"б)a={c} b={a} c={b}");*/

            /*  Console.WriteLine("20 Задание");
            int n = Convert.ToInt32(Console.ReadLine());
            int hours = n / 3600;
            n = n % 3600;
            int minutes = n / 60;
            int seconds = n % 60;

            Console.WriteLine($"Полные часы: {hours}");
            Console.WriteLine($"Полные минуты: {minutes}");
            Console.WriteLine($"Полные секунды: {seconds}");*/

            /* Console.WriteLine("21 Задание");
            int a = 543;
            int b = 130;
            int akv = 130;
            Console.WriteLine((a / akv) * (b / akv));*/

            /* Console.WriteLine("22 Задание");
            int nomer = Convert.ToInt32(Console.ReadLine());
            int digit1 = nomer / 100;
            int digit2 = (nomer / 10) % 10;
            int digit3 = nomer % 10;
            Console.WriteLine($"{digit3}{digit1}{digit2}");*/

            /*  Console.WriteLine("23 Задание");
            int nomer = Convert.ToInt32(Console.ReadLine());
            int t = nomer / 1000;
            int c = nomer / 100;

            Console.WriteLine($"a){c}\nб){t}");*/

            /*  Console.WriteLine("24 Задание");
            int nomer = Convert.ToInt32(Console.ReadLine());
            int digit1 = nomer / 1000;
            int digit2 = (nomer / 100) % 10;
            int digit3 = (nomer / 10) % 10;
            int digit4 = nomer % 10;
            if (digit4 == 0)
            {
                Console.WriteLine($"a){digit3}{digit1}{digit2}");
            }

            else
            {
                Console.WriteLine($"a){digit4}{digit3}{digit1}{digit2}");
            }

            if (digit2 == 0)
            {
                Console.WriteLine($"б){digit1}{digit4}{digit3}");
            }
            else
            {
                Console.WriteLine($"б){digit2}{digit1}{digit4}{digit3}");
            }
            Console.WriteLine($"в){digit1}{digit3}{digit2}{digit4}");
            if (digit3 == 0)
            {
                Console.WriteLine($"г){digit4}{digit1}{digit2}");
            }
            else
            {
                Console.WriteLine($"г){digit3}{digit4}{digit1}{digit2}");
            }*/

            /* Console.WriteLine("26 Задание"); 
            double h = Convert.ToInt32(Console.ReadLine());
            double m = Convert.ToInt32(Console.ReadLine());
            double s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(h * 30 + m * 0.5 + s * (0.5 / 60));*/

            /* Console.WriteLine("28 Задание");  
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double min = Math.Min(Math.Abs(a), Math.Abs(b));
            Console.WriteLine(Math.Min(min, Math.Abs(c)));*/

            /* Console.WriteLine("29 Задание");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double min = Math.Min(a, Math.Min(b, c));
            double max = Math.Max(a, Math.Max(b, c));
            Console.WriteLine(max + min);*/

            /* Console.WriteLine("31 Задание");
            Console.WriteLine("Введите коэффициенты A, B, C, D");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int D = Convert.ToInt32(Console.ReadLine());


            for (int X = -100; X <= 100; X++)
            {
                int result = A * X * X * X + B * X * X + C * X + D;
                if (result == 0)
                {
                    Console.WriteLine($" X = {X}");
                }
            }*/

            /* Console.WriteLine("32 Задание");   
            Console.WriteLine("Введите a1 a2 n соответственно");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double a2 = Convert.ToDouble(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            double d = a2 - a1;
            double an = a1 + (n - 1) * d;
            Console.WriteLine($"a{n}={an}");*/

            /* Console.WriteLine("34 Задание");
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine($"Ваше имя: {name}");
            Console.WriteLine("Введите ваше имя:");
            string Name = Console.ReadLine();
            Console.WriteLine($"Привет, {Name}!");*/


        }
    }
}

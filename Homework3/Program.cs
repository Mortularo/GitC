using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutData;

namespace Homework3
{
    #region Структура
    public struct Complex
    {
        public double re;
        public double im;

        public Complex Plus(Complex x)
        {
            Complex y = new Complex();
            y.re = re + x.re;
            y.im = im + x.im;
            return y;

        }
        public Complex Minus(Complex x)
        {
            Complex y = new Complex();
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }
        public override string ToString()
        {
            return $"{re}+{im}i";
        }
    }
    #endregion
    #region Класс
    public class ComplexClass
    {
        public double re;
        public double im;

        public ComplexClass Plus(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.re = re + x.re;
            y.im = im + x.im;
            return y;

        }
        public ComplexClass Minus(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }
        public ComplexClass Mult(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.re = re * x.re;
            y.im = im * x.im;
            return y;
        }
        public override string ToString()
        {
            return $"{re}+{im}i";
        }
    }
    #endregion
    internal class Program
    {

        static void Main(string[] args)
        {
            Initial.PrintInfo("Денис Теребенин", 3);
            #region Меню
            bool any = (true);
            while (any)
            {
                Console.Write("Для перехода к заданиям введите:\n1а - 1\n1б - 2\n2 - 3\nВыход - 0\nВвод: ");
                int x;
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    switch (x)
                    {
                        case 1:
                            Task1a();
                            break;
                        case 2:
                            Task1b();
                            break;
                        case 3:
                            Task2();
                            break;
                        case 0:
                            any = false;
                            break;
                        default:
                            Console.WriteLine("Ошбичное значение. Посторите ввод.");
                            break;
                    }

                }else 
                {
                    Console.WriteLine("Ошибка ввода");
                }
               
            }
            Console.WriteLine("Завершение работы");
            Console.ReadLine();
        }
        #endregion
        #region Задание 1а.
        static void Task1a()
        {
            Complex complex1 = new Complex();
            Console.Write("Введите вещественную часть первого числа - ");
            complex1.re = double.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть первого числа - ");
            complex1.im = double.Parse(Console.ReadLine());
            Complex complex2 = new Complex();
            Console.Write("Введите вещественную часть второго числа - ");
            complex2.re = double.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть второго числа - ");
            complex2.im = double.Parse(Console.ReadLine());


            Console.Write($"Работа с комлексмыми числами {complex1} и {complex2}.\nДля сложения введите 1, для вычитания введите 2\nВведите нужное значение: ");
            int var = int.Parse(Console.ReadLine());
            switch (var)
            {
                case 1:
                    Complex complex3 = complex1.Plus(complex2);
                    Console.WriteLine($"Результат сложения данных чисел - {complex3}");
                    break;
                case 2:
                    Complex complex4 = complex1.Minus(complex2);
                    Console.WriteLine($"Результат вычитания данных чисел - {complex4}");
                    break;
                default:
                    Console.WriteLine("Выбрано неверное действие");
                    break;

            }

            Console.ReadLine();
        }
        #endregion
        #region Задание 1б.
        static void Task1b()
        {
            ComplexClass com1 = new ComplexClass();
            Console.Write("Введите вещественную часть первого числа - ");
            com1.re = double.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть первого числа - ");
            com1.im = double.Parse(Console.ReadLine());
            ComplexClass com2 = new ComplexClass();
            Console.Write("Введите вещественную часть второго числа - ");
            com2.re = double.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть второго числа - ");
            com2.im = double.Parse(Console.ReadLine());


            Console.Write($"Работа с комлексмыми числами {com1} и {com2}.\nДля сложения введите 1, для вычитания введите 2, для умножения введите 3\nВведите нужное значение: ");
            int var = int.Parse(Console.ReadLine());
            switch (var)
            {
                case 1:
                    ComplexClass com3 = com1.Plus(com2);
                    Console.WriteLine($"Результат сложения данных чисел - {com3}");
                    break;
                case 2:
                    ComplexClass com4 = com1.Minus(com2);
                    Console.WriteLine($"Результат вычитания данных чисел - {com4}");
                    break;
                case 3:
                    ComplexClass com5 = com1.Mult(com2);
                    Console.WriteLine($"Результат вычитания данных чисел - {com5}");
                    break;
                default:
                    Console.WriteLine("Выбрано неверное действие");
                    break;

            }

            Console.ReadLine();

        }
        #endregion
        #region Задание 2. 
        static void Task2()
        {
            int sum = 0;
            Console.WriteLine("Вводите любые целые числа. Для завершения ввода нажмите 0");
            while (true)
            {
                int x;
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    if (x != 0)
                    {
                        if (x % 2 == 0 || x < 0)
                        {
                        }
                        else
                            sum = sum + x;
                    }
                    else
                    {
                        break;
                    }
                    

                } else
                {
                    Console.WriteLine("Ошибка ввода данных");
                }
               
            }
            Console.WriteLine($"Сумма положительных нечетных чисел равна {sum}");
            Console.ReadLine();
        } 
    }
}
#endregion
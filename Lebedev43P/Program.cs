using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebedev43P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Выберете номер для решения примера");
            Console.WriteLine("1) Возведения числа в степень второго ✔");
            Console.WriteLine("2) Периметр и площадь прямоугольного треугольника ✘");
            Console.WriteLine("3) Дает ли введенное с клавиатуры число одинаковый остаток ✘");
            Console.WriteLine("4) Печатает в столбик все цифры введенного nзначного(n от 1 до 10) числа в порядке возрастания разрядов.✔ ✘");
            Console.WriteLine("5) Значение выражения с ручным вводом x&y ✔");
            Console.WriteLine("6) Последовательность n первых чисел Фибоначчи");
            Console.WriteLine("7) Оператор цикла ✔");
            Console.WriteLine("8) Вводит результаты соревнований по плаванию трёх спортсменов ✔ ✘");
            string a = Console.ReadLine();

            switch (a)
            {
                case "1":
                    Console.Clear();
                    Program program1 = new Program();
                    program1.Ex1();
                    break;
                case "2":
                    Console.Clear();
                    Program program2 = new Program();
                    program2.Ex2();
                    break;
                case "3":
                    Console.Clear();
                    Program program3 = new Program();
                    program3.Ex3();
                    break;
                case "4":
                    Console.Clear();
                    Program program4 = new Program();
                    program4.Ex4();
                    break;
                case "5":
                    Console.Clear();
                    Program program5 = new Program();
                    program5.Ex5();
                    break;
                case "6":
                    Console.Clear();
                    Program program6 = new Program();
                    program6.Ex6();
                    break;
                case "7":
                    Console.Clear();
                    Program program7 = new Program();
                    program7.Ex7();
                    break;
                case "8":
                    Console.Clear();
                    Program program8 = new Program();
                    program8.Ex8();
                    break;
                default:
                    Console.WriteLine("Значение введенего неверно, попробуйте еще раз");
                    Console.ReadLine();
                    break;
                
            }

        }

        public void Ex1()
        {
            Console.WriteLine("Введите первое значение");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Результат a в степени b: {Math.Pow(a,b)}");
            Console.WriteLine($"Результат b в степени a: {Math.Pow(b, a)}");
            Console.ReadLine();
        }

        public void Ex2()
        {
            Console.WriteLine("2"); Console.ReadLine();
        }

        public void Ex3()
        {
            Console.WriteLine("3"); Console.ReadLine();
        }

        public void Ex4()
        {
            List<double> vList = new List<double>();
            string sort = "";
            Console.WriteLine("Введите числа, в случае введения нецелого числа используйте запятую, для отсановки введения значений введите X");
            while (sort != "X")
            {
                sort = Console.ReadLine();
                try
                {
                    vList.Add(Convert.ToDouble(sort));
                }
                catch
                {

                }
            }
            vList.Sort();
            Console.WriteLine($"Введенные значения: {vList.Count.ToString()}");
            Console.WriteLine("Результат сортировки: ");
            for (int i = 0; i < vList.Count; i++)
            {
                Console.WriteLine(vList[i].ToString());
            }
            Console.ReadLine();
        }

        public void Ex5()
        {
            Console.WriteLine("1 + sin√x+1 / cos(12y - 4)");
            Console.WriteLine("Ввдетие значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double up;
            double down;
            up = 1 + Math.Sin(Math.Sqrt(x + 1));
            down = Math.Cos((12 * y) - 4);
            double result = up / down;
            Console.WriteLine($"Результат: {result}");
            Console.ReadLine();
        }

        public void Ex6()
        {
            Console.WriteLine("6"); Console.ReadLine();
        }

        public void Ex7()
        {
            Console.WriteLine("Введите колличество элементов: ");
            double a = Convert.ToInt32(Console.ReadLine());
            double x = 1;
            double y = 2;
            double summ = 0;
            for (int i = 1; i <= a; i++)
            {
                summ += x / y;
                x++; y++;
            }
            Console.WriteLine($"Сумма: {summ}");
            Console.ReadLine();
        }

        public void Ex8()
        {
            List<double> vList = new List<double>();
            string sort = "";
            Console.WriteLine("Введите результаты плавцов, в случае введения нецелого числа используйте запятую, для отсановки введения значений введите X");
            while (sort != "X")
            {
                sort = Console.ReadLine();
                try
                {
                    vList.Add(Convert.ToDouble(sort));
                }
                catch
                {

                }
            }
            vList.Sort();
            Console.WriteLine($"Колличество учатсников: {vList.Count.ToString()}");
            Console.WriteLine("Результаты заплыва: ");
            for (int i = 0; i < vList.Count; i++)
            {
                Console.WriteLine(vList[i].ToString());
            }
            Console.ReadLine();
        }
    }
}

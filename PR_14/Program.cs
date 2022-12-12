//*************************
// практическая работа №14*
// выполнил: Ханов Артур  *
//*************************

using System;

namespace PR_14
{
    internal class Program
    {
         static double MethodPolDel(double a, double b, double epsilon)
        {
            double c;//середина отрезка
            double c1 = 0.0;
            c = c1;
            while (Math.Abs(a - b) >= epsilon)
            {
                c = (a + b) / 2;
                if ((8.01 * Math.Cos(Math.Sqrt(Math.Abs(a))) + 1.02 * (a) - 4.1) * (8.01 * Math.Cos(Math.Sqrt(Math.Abs(c))) + 1.02 * (c) - 4.1) <= 0)
                { b = c; }
                else
                { a = c; }
            }
            return c;
        }
         static void Main(string[] args)
        {
            double a; double b; double epsilon;
            try
            {
                //ввод данных
                Console.WriteLine("левая граница отрезка a");
                double a1 = Convert.ToDouble(Console.ReadLine());
                a = a1;//взятие адреса переменной a
                Console.WriteLine("правая граница отрезка a");
                double b1 = Convert.ToDouble(Console.ReadLine());
                b = b1;//взятие адреса переменной b
                Console.WriteLine("точность расчетов");
                double epsilon1 = Convert.ToDouble(Console.ReadLine());
                epsilon = epsilon1;//взятие адреса переменной epsilon
                //вызов функции
                double x = MethodPolDel(a, b, epsilon);
                Console.WriteLine("Корень уравнения x={0:f2}", x);
            }
            catch (Exception e)//обработка исключения
            {
                Console.WriteLine("Ошибка " + e.Message);
            }
            Console.ReadKey();
        }
    }
}

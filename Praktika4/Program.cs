using System;

namespace Praktika4
{
    class Program
    {
        //Данная функция
        static double Function(double x) => Math.Pow(x, 4) + 0.8 * Math.Pow(x, 3) - 0.4 * Math.Pow(x, 2) - 1.4 * x - 1.2;
        public static void Main()
        {
            //Границы отрезка
            double a = -1.2d;
            double b = -0.5d;
            double c;

            Console.WriteLine("Введите необходимую точность (например 0,0001)");
            double eps = 0.0001;
            try
            {
                eps = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Произошла ошибка при попытке считать число, установлено значение по умолчанию 0,0001");
            }
            double result;

            double fa = Function(a);
            double fc;

            do
            {
                c = (a + b) / 2;
                fc = Function(c);
                if (fa * fc < 0.0)
                    b = c;
                else
                {
                    a = c;
                    fa = fc;
                }
            } while (Math.Abs(a - b) >= eps);
            result = (a + b) / 2;

            Console.WriteLine($"Полученный корень: {result} с точностью равной {eps}");
        }
    }
}

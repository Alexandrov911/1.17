using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.17");
            Console.WriteLine("введите число x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Math.Sqrt(x1*x1+x2*x2);
            Console.WriteLine("ответ: " + x1 + x2);
            Console.ReadKey();

            //1.17 б
            Console.WriteLine("1.17 бъ");
            Console.WriteLine("введите число a1");
            double a1 =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число a2");
            double a2 =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число a3");
            double a3 =Convert.ToDouble(Console.ReadLine());
            double a4 = a1 * a2 + a1 * a3 + a2 * a3;
            Console.WriteLine("ответ:" + a4);
            Console.ReadKey();

            //1.17 в
            Console.WriteLine("1.17 в");
            Console.WriteLine("введите число v0");
            double v0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число t");
            double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число d");
            double d = Convert.ToDouble(Console.ReadLine());
            double d1 = v0 * t + (d * (t *t)/ 2);
            Console.WriteLine("ответ:" + d1);
            Console.ReadKey();
            // 1.17 г
            Console.WriteLine("1.17 г");
            Console.WriteLine("введите число m");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число g");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число h");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число k");
            double k = Convert.ToDouble(Console.ReadLine());
            double q = m * (k * k) / 2 + m * g * h;
            Console.WriteLine("ответ:" + k);
            Console.ReadKey();
            // 1.17 д
            Console.WriteLine("1.17 д");
            Console.WriteLine("введите число r1");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число r2");
            double r2 = Convert.ToDouble(Console.ReadLine());
            double q1 = (1 / r1) + (1 / r2);
            Console.WriteLine("ответ:" + q1);
            Console.ReadKey();
            //1.17 e
            Console.WriteLine("1.17 е");
            Console.WriteLine("введите число m2");
            double m2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число g1");
            double g1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число cosa");
            double cosa = Convert.ToDouble(Console.ReadLine());
            double q2 = m2 * g1 * cosa;
            Console.WriteLine("ответ:" + q2);
            Console.ReadKey();



















        }
    }
}

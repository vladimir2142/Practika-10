using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество действительных чисел");
            int n = int.Parse(Console.ReadLine());
            double [] ar = new double[n];
            Console.WriteLine("Введите действительные числа");
            for (int i=0;i<n;i++)
            {
                ar[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ваш список");
            for (int i = 0; i < n; i++)
            {
                Console.Write(ar[i] + " ");
            }
            double sum = 0;
            for (int i=0; i<n;i++)
            {
                sum =sum +ar[i] * ar[n - i-1];
            }
            Console.WriteLine("Сумма=" + sum);
            Console.Read();
           
        }
    }
}

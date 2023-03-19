 using System;
 namespace Сумма_чисел
 {
    class Program
    {
       static int n_min, n_max;
       static int sum;
       static void Main(string[] args)
       {
          ввод();
          сумма1();
          вывод("Сумма чисел через цикл = ");
          Console.ReadKey();
       }
       static void ввод()
       {
          Console.Write("начальное число = ");
          n_min = Convert.ToInt32(Console.ReadLine());
          Console.Write("конечное число = ");
          n_max = Convert.ToInt32(Console.ReadLine());
       }
       static void сумма1()
       {
          sum = 0;
          for (int i = n_min; i <= n_max; i++)
          sum = sum + i;
       }
       static void вывод(string z)
       {
          z = z + sum.ToString();
          Console.WriteLine(z);
       }
    }
 }
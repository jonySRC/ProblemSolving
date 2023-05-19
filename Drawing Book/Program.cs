using System;
using System.IO;

namespace Drawing_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@"D:\result.txt", true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int p = Convert.ToInt32(Console.ReadLine().Trim());

            int result = pageCount(n, p);

            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
       
        private static int pageCount(int n, int p)
        {
            //int t=1, tb=0, tf=0;


            //    if ((p == 1) || (p == n) || (p == n - 1))
            //    {
            //        return 0;
            //    }
            //    for (int i = 3; i <= n; i = i + 2)
            //    {
            //        t++;

            //        if (p == i || p == i - 1)
            //        {
            //            tf = t;

            //        }

            //    }
            //    tb = t - tf;

            //    if (tb > tf)
            //    {
            //        return tf;
            //    }
            //    else
            //    {
            //        return tb;
            //    }

            int a =  p / 2;
            int b = n / 2 - p / 2;

            if (a > b)
            {
                return b;
            }
            else return a;
            
        }
    }
} 

using System;
using System.IO;

namespace Cats_and_a_Mouse
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@"D:\result.txt", true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }

        static string catAndMouse(int x, int y, int z)
        {
            int a=0, b=0, c=0;
            if (y > x)
            {
                if (z > y)
                    b = z - y;
                else
                   b = y - z;

                if(x>z)
                    a = x - z;
                else
                    a = z - x;

            }
            else if (x > y)
            {
                if (z > x)
                    a = z - x;
                else
                    a = x - z;

                if (z > y)
                    b = z - y;
                else
                    b = y - z;
            }

            if (a > b && a != b)
                return "Cat B";
            else if(b > a && a != b)
                return "Cat A";
            else
                return "Mouse C";
        }
    }
}

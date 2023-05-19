using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Forming_a_Magic_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@"D:\result.txt", true);

            List<List<int>> s = new List<List<int>>();

            for (int i = 0; i < 3; i++)
            {
                s.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
            }

            int result = formingMagicSquare(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        public static int formingMagicSquare(List<List<int>> s)
        {
            int j = 0, y = 0, k = 0;
            for (int i = 0; i < 9; i++)
            {
                
                if (i % 3 == 0 && i != 0)
                {
                    j++;
                    i = 0;
                }
                if (j < 3)
                {

                    for (int m = 1; m <= 4; m++)
                    {
                        int xy = s[j][i] - s[1][1] > 0 ? s[j][i] - s[1][1] : (s[j][i] - s[1][1]) * (-1);
                        if (i == 0 && j == 0)
                        {
                            if (xy == m && s[2][2] != 15 - (s[j][i] + s[1][1]))
                            {
                                int a = s[2][2] - (15 - (s[j][i] + s[1][1]));
                                a = a > 0 ? a : a * (-1);
                                k += a;
                                break;

                            }
                            else if (xy == 0)
                            {
                                int a = s[j][i] - (15 - (s[2][2] + s[1][1]));
                                a = a > 0 ? a : a * (-1);
                                k += a;
                                break;
                            }
                        }

                        else if (i == 0 && j == 1)
                        {
                            if (xy == m && s[2][1] != 15 - (s[j][i] + s[1][1]))
                            {
                                int a = s[2][1] - (15 - (s[j][i] + s[1][1]));
                                a = a > 0 ? a : a * (-1);
                                k += a;
                                break;

                            }
                            else if (xy == 0)
                            {
                                int a = s[j][i] - (15 - (s[2][1] + s[1][1]));
                                a = a > 0 ? a : a * (-1);
                                k += a;
                                break;
                            }
                        }

                        else if (i == 0 && j == 2)
                        {
                            if (xy == m && s[2][0] != 15 - (s[j][i] + s[1][1]))
                            {
                                int a = s[2][0] - (15 - (s[j][i] + s[1][1]));
                                a = a > 0 ? a : a * (-1);
                                k += a;
                                break;

                            }
                            else if (xy == 0)
                            {
                                int a = s[j][i] - (15 - (s[2][0] + s[1][1]));
                                a = a > 0 ? a : a * (-1);
                                k += a;
                                break;
                            }
                        }

                        else if (i == 1 && j == 0)
                        {
                            if (xy == m && s[1][2] != 15 - (s[j][i] + s[1][1]))
                            {
                                int a = s[1][2] - (15 - (s[j][i] + s[1][1]));
                                a = a > 0 ? a : a * (-1);
                                k += a;
                                break;

                            }
                            else if (xy == 0)
                            {
                                int a = s[j][i] - (15 - (s[1][2] + s[1][1]));
                                a = a > 0 ? a : a * (-1);
                                k += a;
                                break;
                            }
                        }

                    }



                }
                else
                    break;


                Console.WriteLine(k);


            }



            return k;
        }
    }
}

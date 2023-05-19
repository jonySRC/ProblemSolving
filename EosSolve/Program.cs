using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace EosSolve
{
    class Program
    {
        static void Main(string[] args)
        {
            string ptn = "";
            string str = "{HHmm}{NNN}";
            var strarr = str.Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in strarr)
            {
                if (item.Contains('d') || item.Contains('M') || item.Contains('Y'))
                {
                    string date = DateTime.Now.Date.ToString(item);
                    ptn = $"{ptn}{date}";

                }
                else if (item.Contains('H')||item.Contains('m'))
                {
                    string time = DateTime.Now.ToString(item);
                    ptn = $"{ptn}{time}";
                }
                else if (item.Contains('N'))
                {
                    string numpt = item.Replace('N','0');
                    ptn = $"{ptn}{numpt}";
                }
                else
                {
                    ptn = $"{ptn}{item}";
                }
            }
            Console.WriteLine(ptn);
        }
    }
}

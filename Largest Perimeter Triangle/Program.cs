using System;

namespace Largest_Perimeter_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 3, 2, 3, 4 };
            
            Console.WriteLine(LargestPerimeter(data));
        }

        public static int LargestPerimeter(int[] nums)
        {
            int sum = 0;
            int a=0, b=0, c=0;
            Array.Sort(nums);
            for (int i = nums.Length-1; i >= 0; i--)
            {
                if (sum>0)
                {
                    break;
                }
                if (i>=2)
                {
                    a = nums[i];
                    b = nums[i - 1];
                    c = nums[i - 2];
                }
                
                if (a+b>c && a+c>b && b+c>a)
                {
                   
                  sum = a+b+c;
                    
                }
                              
            }

            return sum;
        }

    }
}

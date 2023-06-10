using System;
using System.Linq;

namespace MIU_Privious_Years_Problems
{
    class Program
    {
        static void Main(string[] args)
        {       
            int[] a = { 7, 1, 2, 1, 7, 4, 2, 7 };
            Console.WriteLine(maxOccurDigit58of1(327277));
        }
        public static int isEvenSubset30of1(int m, int n)
        {
            int res = 0;
            for (int i = 2; i < m; i++)
            {
                if (i % 2 == 0)
                {
                    if (m % i == 0)
                    {
                        if (n % i != 0)
                        {
                            res = 0;
                            break;
                        }
                        else
                        {
                            res = 1;
                        }
                    }
                }

            }

            return res;
        }

        public static int isTwinoid30of2(int[] a) 
        {
            int adjacentEventCount = 0, res=0;
            bool isAdjacent=false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]%2==0)
                {
                    adjacentEventCount++;
                }

                if (i!=a.Length-1)
                {
                    if (a[i] % 2 == 0 && a[i + 1] % 2 == 0)
                    {
                        isAdjacent = true;
                    }
                }
              
            }

            if (isAdjacent && adjacentEventCount==2)
            {
                res = 1;
            }
            return res;
        }

        public static int isBalanced30of3(int[] a) 
        {
            int res = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (i!=j)
                    {
                        if (a[i] + a[j]==0)
                        {
                            res = 1;
                        }

                    }
                   
                }
                if (res==0)
                {
                    break;
                }
            }

            return res;
        }

        public static int getExponent31of1(int n, int p) 
        {
            int res = 0,count=0;

            for (int i = p; i <= n; i = i * p)
            {
                if (n % i==0)
                {
                    count++;
                }
                
            }
            return count;

        }

        public static int hasSingleMode56of1(int[] a) 
        {
            int modeValue=0,res=0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (i!=j)
                    {
                        if (a[i]==a[j])
                        {
                            if (a[i]!=modeValue && modeValue!=0) //1, 2, 3, 4, 2, 4, 7
                            {
                                res = 0;
                                break;
                            }
                            else
                            {
                                res = 1;
                            }
                            modeValue = a[i];
                        }

                    }
                }

            }

            return res;
        }

        public static int maxOccurDigit(int n) 
        {
            if (n<0)
            {
                n = n * -1;
            }
            int itemCurrentCount = 0,maxCurrentItem=0, maxPrevioustItem=0 ,itemPrevioustCount =0,item=n;

            for (int i = 0; 0 != item; i++)
            {   
                int iteme = item % 10;
                int itemExist = n;
                itemCurrentCount = 0;

                for (int j = 0; 0 != itemExist; j++)
                {
                    int itemex = itemExist % 10;
                    if (itemex == iteme)
                    {
                        maxCurrentItem = iteme;
                        itemCurrentCount++;
                    }
                    itemExist = itemExist / 10;


                }
                if (itemPrevioustCount < itemCurrentCount)
                {
                    maxPrevioustItem = maxCurrentItem;
                    itemPrevioustCount = itemCurrentCount;
                }

                item = item / 10;

            }

            if (maxPrevioustItem > maxCurrentItem)
            {
                return maxPrevioustItem;
            }
            if (maxPrevioustItem == maxCurrentItem)
            {
                return -1;
            }

            return maxCurrentItem;

        }

        public static int maxOccurDigit58of1(int n)
        {
            if (n < 0)
            {
                n = n * -1;
            }
            int[] items = new int[10];
            int maxCount = 0,res=0;
             
            for (int i = 0; 0!=n; i++)
            {
                int item = n % 10;
                items[item]++;
                n=n/10;
                
            }


            for (int i = 0; i < items.Length; i++)
            {
                if (i != 0) 
                {
                    if (items[i] == maxCount)
                    {
                        res = -1;
                    }
                    else if (items[i] > res)
                    {
                        res = i;
                        maxCount = items[i];
                    }
                }
                           
            }

            return res;

        }


        //public static int maxOccurDigit58of1_Test(int n)
        //{
        //    int one = 0, two = 0, three = 0, four = 0, five = 0, six = 0, seven = 0, eight = 0, nine = 0, res=one;

        //    for (int i = 0; 0 != n; i++)
        //    {
        //        int item = n % 10;
        //        switch (item)
        //        {
        //            case 1:
        //                one++;
        //                break;
        //            case 2:
        //                two++;
        //                break;
        //            case 3:
        //                three++;
        //                break;
        //            case 4:
        //                four++;
        //                break;
        //            case 5:
        //                five++;
        //                break;
        //            case 6:
        //                six++;
        //                break;
        //            case 7:
        //                seven++;
        //                break;
        //            case 8:
        //                eight++;
        //                break;
        //            case 9:
        //                nine++;
        //                break;
        //            default:
        //                break;
        //        }
        //        n = n / 10;
        //    }

            
        //        if (two>res)
        //        {
        //            res = two;
        //        }
            
            


        //}
    }
}

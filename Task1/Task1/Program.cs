using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {


            #region 1ci versiya
            //int N = Convert.ToInt32(Console.ReadLine());
            //if (N % 7 == 0) { Console.WriteLine("7-ye bolunur"); }
            //else { Solv1(N, 7); }




            #endregion

            #region 2ci versiya
            //int N = Convert.ToInt32(Console.ReadLine());
            //Solv2(N, 7);
            #endregion

            #region 3cu versiya
            //int N = Convert.ToInt32(Console.ReadLine());
            //if (N % 7 == 0) { Console.WriteLine("7-ye bolunur"); }
            //else { Solv3(N, 7); }
            #endregion 



        }
        public static void Solv1(int num1,int num2)

        {
            
            int num3 = num1 % num2;
            num1 = num1 - num3;
            Console.WriteLine(num1);
        }
        public static void Solv2(int num1,int num2)
        {
            if (num1 % num2 == 0)
            { 
                Console.WriteLine(num2+" ededine bolunur"); 
            }
            else 
            {
                int num3 = num1 % num2;
                num1 = num1 - num3;
                Console.WriteLine(num1);
            }

            
            
        }
        public static void Solv3(int num1,int num2) 
        {
            while (num1%num2!=0)
            {
                num1--;
            }

            Console.WriteLine(num1);

        }
        


    }

}

using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1ci versiya
            //int N = Convert.ToInt32(Console.ReadLine());
            //int B = Convert.ToInt32(Console.ReadLine());
            //char O = Convert.ToChar(Console.ReadLine());
            //Solv(N, B, O);
            #endregion

            #region 2ci versiya

            //int N = Convert.ToInt32(Console.ReadLine());
            //int B = Convert.ToInt32(Console.ReadLine());
            //char O = Convert.ToChar(Console.ReadLine());
            //if (O == '+' || O == '-' || O == '*' || O == '/')
            //{
            //    Solv2(N, B, O);
            //}
            //else
            //{
            //    Console.WriteLine("please choose one of these operators:'+','-','*','/'");
            //    O = Convert.ToChar(Console.ReadLine());
            //    Solv2(N, B, O);
            //}
            #endregion


        }
        public static void Solv(int num1, int num2, char opr)
        {
            int operation = 0;
            if (opr == '+') { operation = num1 + num2; Console.WriteLine(operation); }
            else if (opr == '-') { operation = num1 - num2; Console.WriteLine(operation); }
            else if (opr == '*') { operation = num1 * num2; Console.WriteLine(operation); }
            else if (opr == '/') { operation = num1 / num2; Console.WriteLine(operation); }
            else { Console.WriteLine("please choose another operator"); }


        }
        public static void Solv2(int num1, int num2, char opr)
        {
            int operation = 0;
            if (opr == '+') { operation = num1 + num2; }
            else if (opr == '-') { operation = num1 - num2; }
            else if (opr == '*') { operation = num1 * num2; }
            else { operation = num1 / num2; }
            Console.WriteLine(operation);









        }
    }
}

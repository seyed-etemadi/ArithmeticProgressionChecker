using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            // دریافت سه عدد از کاربر
            Console.WriteLine(" Please enter three numbers: ");
            Console.WriteLine("Num 1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Num 2 : ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Num 3 : ");
            num3 = int.Parse(Console.ReadLine());

            // بررسی تشکیل تصاعد حسابی
            if ((num2 - num1) == (num3 - num2))
            {
                Console.WriteLine(" The progression is arithmetic. ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(" The progression is not arithmetic. ");
                Console.ReadKey();
            }
        }
    }
}

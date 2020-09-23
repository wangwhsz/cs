using System;

namespace ExecuteLeapYear
{
        class ExecuteLeapYear
    {
        static void Main1(string[] args)
        {
            int Year;
            Year = Convert.ToInt32(Console.ReadLine());
            if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0){
                Console.WriteLine("{0}是闰年",Year);
            }
                else Console.WriteLine("{0}不是闰年");
            Console.ReadLine();
            
        }
    }
}
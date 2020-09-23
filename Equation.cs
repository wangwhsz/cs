using System;
namespace Equetion
{
    class Equation{
        static void Main1(string[] args){
            double A,B,C;
            double Res_1,Res_2;
            double Delta;
            
            Console.WriteLine("请输入A的值：");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入B的值：");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入C的值：");
            C = double.Parse(Console.ReadLine());

            Delta = (Math.Pow(B,2) - (4 * A * C));

            if( Delta > 0){
                Res_1 = ( -B + Math.Sqrt(Delta)/ 2 * A);
                Res_2 = ( -B - Math.Sqrt(Delta)/ 2 * A);
                Console.WriteLine("方程的两个解为:{0},{1}",Res_1,Res_2);
            }
                else if( Delta == 0 ){
                    Res_1 = Res_2 = -B / 2*A;
                    Console.WriteLine("此方程两个解都为:{0}",Res_1);
                }
                    else {
                        Console.WriteLine("此方程无解");
                    }
            Console.ReadLine();

        }
    }
}
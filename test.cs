using System;

namespace Test
{
    class Factorial{
        public int Execute(int n){
            int result;
            if(n == 1){
                return 1;
            }
                else {
                    result = (Execute(n - 1) * n);
                    return result;
                }
        }
    }
    class Test{
         
        static void Main(){
            int num;
            Console.WriteLine("请输入一个整数:");
            num = Convert.ToInt32(Console.ReadLine());
            Factorial n = new Factorial();
            int result;
            result = n.Execute(num);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

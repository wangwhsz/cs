using System;
namespace Fibonacci
{
    class Fibonacci{
        static void Main111(string[] args){
            int[] nArray = new int[10];
            int count = 2;
            nArray[1] = 1;
            nArray[0] = 1;
            for(count = 2; count < 10 ; count++){
                nArray[count] = nArray[count - 1] + nArray[count - 2];
            }
            for(count  = 0; count < 10; count++){
                Console.Write(nArray[count]);
                Console.Write("\t");
            }
            Console.ReadLine();
            
        }
    }
}
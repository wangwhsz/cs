using System;
namespace ExecuteNum
{
    class ExecuteNum
    {
        static void Main11(string[] args){
            int eNum_1,eNum_2;
            int SwapVar;
            int Rem;
            int Multi;
            Console.WriteLine("请输入两个数:");
            eNum_1 = Convert.ToInt32(Console.ReadLine());
            eNum_2 = Convert.ToInt32(Console.ReadLine());
            if(eNum_1<eNum_2){
                SwapVar=eNum_1;
                eNum_1=eNum_2;
                eNum_2=SwapVar;
            }
            Multi= eNum_1 * eNum_2;
            Rem = eNum_1 % eNum_2;
            while(Rem!=0)
            {
                eNum_1 = eNum_2;
                eNum_2=Rem;
                Rem=eNum_1 % eNum_2;
            }
            Console.WriteLine("最大公约数是:{0}",eNum_2);
            Console.WriteLine("最小公倍数是:{0}",Multi/eNum_2);
            Console.ReadLine();
        }
    }
}

using System;

namespace D23_Mm
{
    class Program
    {
    
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int i, maior, menor, num; 
            
            for(i=1; i<=10;i++){
                System.Console.WriteLine("Digite o número: " +i);
                num = int.Parse(Console.ReadLine());
            
                if(i==1){
                    maior=num;
                    menor=num;
                }else{
                    if(num<menor){
                        menor=num;
                    }
                }
            }
            System.Console.WriteLine("O menor número é " +menor+" e o maior número é " +maior);
            
        }
    }
}

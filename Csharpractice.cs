using System;
using System.Linq; 

namespace Csharp_practice
{
    class Program
    {   
        public static long Sn(long n){
            return n*(n+1)/2;
        }



        
        public static void Main()
        {
            long[] arr = (Console.ReadLine())
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            long x = arr[0],  b = arr[1];


            for(long i = b; i <=100; i++){
                if((x - Sn(i-1))%i == 0 && (x - Sn(i-1))/i >= 0){
                    long m = (x - Sn(i-1))/i;
                    for(long j = m; j < m+i; j++){
                        Console.Write($"{j}");
                         if(j != m + i){
                            Console.Write(" ");
                        }
                    }
                    return;
                }
            }

            Console.WriteLine("-1");


            
        }
       
    }
}
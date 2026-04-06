using System;
using System.Linq; 
using System.Collections.Generic;

namespace Csharp_practice
{
    class Program
    {

        public static bool isclose(int a, int b, int x, int y)
        {
            if((a + 1 == x || a - 1 == x) && (b+1==y || b-1 == y))
                return true;
            else
                return false;
        }
        public static List<List<int>> union(List<List<int>> matrix, int x, int y)
        {
            bool close = false;
            foreach(List<int> row in matrix)
            {
                int a = row[0];
                int b = row[1];
                if (isclose(a, b, x, y))
                {
                    
                }

            }

            return matrix;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int a = arr[0], b = arr[1], c = arr[2];
                List<List<List<int>>> matrix = new List<List<List<int>>>();
                for(int j = 0; j < c; j++)
                {
                    int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    int x = arr1[0], y = arr1[1];
                }

            }

        }
    }
}
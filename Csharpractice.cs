using System;
using System.Linq; 
using System.Collections.Generic;

namespace Csharp_practice
{
    class Program
    {

        public static bool isclose(int a, int b, int x, int y)
        {
            return Math.Abs(a - x) + Math.Abs(b - y) == 1;
        }

        public static List<List<List<int>>> merge(List<List<List<int>>> matrix, List<int> indexes, List<int> dot)
        {
            List<List<int>> mergedGroup = new List<List<int>>();
            mergedGroup.Add(dot);

            foreach (int idx in indexes)
            {
                mergedGroup.AddRange(matrix[idx]); 
                matrix[idx].Clear();               
            }

            // 내용물이 비어있는(Clear된) 리스트들을 한꺼번에 삭제
            matrix.RemoveAll(group => group.Count == 0);

            // 마지막에 통합된 그룹 추가
            matrix.Add(mergedGroup);

            return matrix;
        }

        public static List<List<List<int>>> union(List<List<List<int>>> matrix, int x, int y)
        {
            List<int> indexes = new List<int>();
            bool close = false;
            for(int i = 0; i < matrix.Count; i++)
            {
                List<List<int>> row = matrix[i];
                bool foundInThisRow = false;

                foreach(List<int> dots in row)
                {   
                    int a = dots[0], b = dots[1];
                    if (isclose(a, b, x, y))
                    {
                        indexes.Add(i);
                        close = true;
                        break;
                    }
                }
            }
            if(close){
                if(indexes.Count == 1){
                    matrix[indexes[0]].Add(new List<int>{x,y});
                }
                else
                {
                    matrix = merge(matrix, indexes,new List<int>{x,y});
                }
            }
            else{
                matrix.Add(new List<List<int>> {new List<int>{x,y}});
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
                    matrix = union(matrix,x,y);
                }
                Console.WriteLine(matrix.Count);
            }

        }
    }
}
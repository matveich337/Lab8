using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3, 3];
            Random r = new Random();
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i, j] = r.Next(100);
                }
            }
            Action<int[,]> act1 = Show;
            ChangeMatrix(arr1, act1);
            act1 = ShowPositive;
            ChangeMatrix(arr1, act1);
            act1 = Mult3;
            ChangeMatrix(arr1, act1);
            act1 = Show;
            ChangeMatrix(arr1, act1);
        }
        static void ChangeMatrix(int[,] arr, Action<int[,]> act)
        {
            act.Invoke(arr);
        }
        static void Show(int[,] arr)
        {
            Console.WriteLine("Matrix: ");
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void ShowPositive(int[,] arr)
        {
            Console.WriteLine("Positive elements: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(arr[i, j] > 0)
                        Console.Write(arr[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
        static void Mult3(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = arr[i, j] * 3;
                }
            }
        }
    }
}
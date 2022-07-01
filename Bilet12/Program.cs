﻿using System;
using System.Threading.Tasks;

namespace Bilet12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new int[100];
            var arr2 = new int[100];

            Fill(arr1);
            Fill(arr2);
            Sum(arr1, arr2);
        }

        private static void FillArray(int[] array)
        {
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100);
            }

        }

        private static async void Fill(int[] array)
        {
            await Task.Run(() => FillArray(array));
        }

        public static void Sum(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i] + arr2[i]);
            }
        }
    }
}

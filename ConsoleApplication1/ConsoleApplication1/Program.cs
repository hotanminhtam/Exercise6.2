using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csquicksort
{
    class Testquicksort
    {
        private static void Quick_Sort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(a, left, right);
                if (pivot > 1)
                {
                    Quick_Sort(a, left, pivot - 1);

                }

                if (pivot + 1 < right)
                {
                    Quick_Sort(a, pivot + 1, right);
                }
            }
            foreach (int item in a)
                Console.Write(item + " ");
            Console.WriteLine("\n");
        }
        private static int Partition(int[] a, int left, int right)
        {
            int pivot = a[left];
            while (true)
            {
                while (a[left] < pivot)
                {
                    left++;
                }
                while (a[right] > pivot)
                {
                    right--;

                }

                if (left < right)
                {
                    if (a[left] == a[right]) return right;
                    int temp = a[left];
                    a[left] = a[right];
                    a[right] = temp;

                }
                else
                {
                    foreach (int item in a)
                        Console.Write(item + " ");
                    Console.WriteLine("\n");
                    return right;
                }
                foreach (int item in a)
                    Console.Write(item + " ");
                Console.WriteLine("\n");
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 20, 5, -14, 11, -13, 67, 31, 60, 19, 101, 17 };

            Console.WriteLine("Chuong trinh xep nhanh: ");

            Console.WriteLine("\nMang ban dau la: ");
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();



            Quick_Sort(a, 0, a.Length - 1);

            Console.WriteLine();
            Console.WriteLine("\nIn ket qua Mang sap xep la: ");

            foreach (int item in a)
                Console.Write(item + " ");
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HW(1)
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Задание №1");           
            Console.WriteLine("Введите размерность массива: ");          
            int n = int.Parse(Console.ReadLine());
           // Console.Write("m=");
            //int m = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random r = new Random();
            int even;
            int odd;
            even = 0;
            odd = 0;          
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = r.Next(1, 99);
                }             
            Console.WriteLine("Ваш массив:");           
               for (int j = 0; j < arr.Length; j++)
               {
                Console.Write("{0,5}", arr[ j]);
               }                                                                     
               for (int j = 0; j < arr.Length; j++)
               {
                     if (arr[j] % 2 == 0)
                     {
                        even++;
                     }                          
               }                                               
            odd = arr.Length - even;
            Console.WriteLine($"\nКоличество четных: {even}, количество нечетных: {odd}");
            #endregion

            #region HW(2)
            Console.WriteLine("\nЗадание №2");
            Console.WriteLine("Введите размерность массива: ");          
            int m = int.Parse(Console.ReadLine());
            // Console.Write("m=");
            //int m = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            Random R = new Random();
            
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = r.Next(1, 99);
            }
            Console.WriteLine("Ваш массив:");
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write("{0,3}  ", arr[j]);
            }
            Console.WriteLine("\t");
            #endregion

            












        }
    }
}

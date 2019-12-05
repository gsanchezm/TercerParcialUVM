using System;
using System.Linq;

namespace TercerParcial
{
    public class EjercicioDos
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] intArr = new int[100];

            for (int i = 0; i < intArr.Length; i++)
            {
                int num = rnd.Next(1, 1000);
                intArr[i] = num;
                Console.WriteLine(num);
            }

            Console.WriteLine();
            int maxNum = intArr.Max();
            int minNum = intArr.Min();
            Console.WriteLine("El número mayor es:" + maxNum);
            Console.WriteLine("El número menor es:" + minNum);
            Console.ReadLine();
        }
    }
}

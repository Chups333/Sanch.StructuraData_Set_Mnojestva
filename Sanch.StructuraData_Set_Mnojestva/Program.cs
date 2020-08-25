using Sanch.StructuraData_Set_Mnojestva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.StructuraData_Set_Mnojestva
{
    public class Program
    {
        static void Main(string[] args)
        {
            //HashSet<int> set = new HashSet<int>(); - готовая структура 

            var easySet1 = new EasySet<int>(new int[] { 1, 2, 3, 4, 5 });
            var easySet2 = new EasySet<int>(new int[] { 4, 5, 6, 7, 8 });
            var easySet3 = new EasySet<int>(new int[] { 3, 4, 5 });

            Console.WriteLine("Union");
            foreach (var item in easySet1.Union(easySet2))
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Intersection");
            foreach (var item in easySet1.Intersection(easySet2))
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Differenct A \\ B");
            foreach (var item in easySet1.Difference(easySet2))
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Differenct B \\ a");
            foreach (var item in easySet2.Difference(easySet1))
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Subset A C");
            Console.WriteLine(easySet1.Subset(easySet3));

            Console.WriteLine();
            Console.WriteLine("Subset C A");
            Console.WriteLine(easySet3.Subset(easySet1));

            Console.WriteLine();
            Console.WriteLine("Subset C B");
            Console.WriteLine(easySet3.Subset(easySet2));

            Console.WriteLine();
            Console.WriteLine("SymmetricDifference");
            foreach (var item in easySet1.SymmetricDifference(easySet2))
            {
                Console.WriteLine(item + " ");
            }

            Console.ReadLine();
        }
    }
}

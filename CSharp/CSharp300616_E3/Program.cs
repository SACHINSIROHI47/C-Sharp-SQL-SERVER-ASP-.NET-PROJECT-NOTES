using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp300616_E3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            int[] nums1 = new int[3];
            int[] nums2 = new int[3];

            Console.Write("Enter Numbers for Array1\n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("Enter Number : ");
                nums1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter Numbers for Array2\n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("Enter Number : ");
                nums2[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Here is Nums1: ");
            for(i=0;i<3;i++)
                Console.Write(nums1[i]+" ");
            Console.WriteLine();

            Console.Write("Here is Nums2: ");
            for (i = 0; i < 3; i++)
                Console.Write(nums2[i] + " ");
            Console.WriteLine();

            //now nums2 refer to nums1
            nums2 = nums1;

            Console.Write("Here is Nums2 after assignment: ");
            for (i = 0; i < 3; i++)
                Console.Write(nums2[i] + " ");
            Console.WriteLine();

            nums2[2] = 99;

            Console.Write("Here is Nums1 after changes through num1: ");
            for (i = 0; i < 3; i++)
                Console.Write(nums1[i] + " ");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

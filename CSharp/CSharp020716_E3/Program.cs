using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp020716_E3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int []nums1 = new int[4];
            int []nums2 = new int[4];

            for (i = 0; i < nums1.Length; i++)
                nums1[i] = i;

            Console.Write("Original Contents: ");
            for (i = 0; i < nums1.Length; i++)
                Console.Write(nums1[i] + " ");

            Console.WriteLine();

                if(nums2.Length >= nums1.Length)
                    for(i=0,j=nums1.Length-1;i<nums1.Length;i++,j--)
                        nums2[j]=nums1[i];

            Console.Write("Reverse Contents: ");
            for (i = 0; i < nums1.Length; i++)
                Console.Write(nums2[i] + " ");

             Console.WriteLine();

             Console.ReadLine();

        }
    }
}

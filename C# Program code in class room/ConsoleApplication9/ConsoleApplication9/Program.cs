using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {

        public void arr1()
        {
            int[] arr = new int[10];
            int i;
            for (i = 0; i < 10; i++)
            {
                arr[i] = i;
            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Index No[" + arr[i] + "]:" + arr[i]);
            }
        }

        public void arr2()
        {
            int[] arry = new int[5];
            arry[0]=10;
            arry[1] = 20;
            arry[2] = 30;
            arry[3] = 40;
            arry[4] = 50;
           
            Console.WriteLine(arry[0]+"\t"+arry[1]+"\n"+ arry[2]+"\n"+arry[3]+"\n"+arry[4]);


        }
        public void arr3()
        {
            int[] arr4={10,20,30,400,500};
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Array 3rd: " + arr4[i]);
            }
        }
        public void arrr4()
        {
            int[] num=new int[]{1000,2000,3000,4000};
            Console.WriteLine("Array 4th: "+num[2]);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.arr1();
            obj.arr2();
            obj.arr3();
            obj.arrr4();
            MultiArray obj2 = new MultiArray();
            obj2.multary();
            ThreeDimArray obj3=new ThreeDimArray();
            obj3.threary();
            obj3.arrlength();
            TwoDimArrayRead obj4=new TwoDimArrayRead();
            //obj4.ary();
            //obj4.ary2();
            obj4.frech();

            strng obj5 = new strng();
            obj5.sst();
            Console.ReadLine();


        }
    }
}

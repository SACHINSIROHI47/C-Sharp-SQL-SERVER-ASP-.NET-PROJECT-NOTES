using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp200716_E1
{
    class B
    {
        protected int i, j;

        public void Set(int a, int b)
        {
            i = a;
            j = b;
        }

        public void Show()
        {
            Console.WriteLine(i + " " + j);
        }
    }

    class D : B
    {
        int k; //private

        //D can access B i and j
        public void SetK()
        {
            k = i * j;
        }

        public void ShowK()
        {
            Console.WriteLine(k);
        }
    }
    class ProtectedDemo
    {
        static void Main(string[] args)
        {
            D ob = new D();
            ob.Set(2, 3);
            ob.Show();
            ob.SetK();
            ob.ShowK();

            Console.ReadLine();

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp280616_E4
{
   class Rect
    {
        public int Width;
        public int Height;

        public Rect(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public int Area()
        {
            return this.Width * this.Height;
        }
    }

   class UseRect
   {
       static void Main(string[] args)
       {
           Rect r1 = new Rect(4, 5);
           Rect r2 = new Rect(7, 9);

           Console.WriteLine("Area of r1 : " + r1.Area());
           Console.WriteLine("Area of r2 : " + r2.Area());

           Console.ReadLine();
       }
   }
}

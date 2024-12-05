using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp190716_E2
{
    //A class for two dimensional shape
    class TwoDShape
    {
        double pri_Width;
        double pri_Height;

        //properties for Width
        public double Width
        {
            get
            {
                return pri_Width;
            }
            set
            {
                pri_Width = value < 0 ? -value : value;
            }
        }
        //properties for  Height
        public double Height
        {
            get
            {
                return pri_Height;
            }
            set
            {
                pri_Height = value < 0 ? -value : value;
            }
        }

        public void ShowDim()
        {
            Console.WriteLine("Width and Height are " +
                Width + " and " + Height);
        }
    }
    class Triangle : TwoDShape
    {
        public string Style; //style of Triangle

        //Return area of Triangle
        public double Area()
        {
            return Width * Height / 2;
        }

        //Display a Triangle Style
        public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + Style);
        }
    }
    class Shapes
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle();

            t1.Width = 4.0;
            t1.Height = 4.0;
            t1.Style = "isosceles";

            t2.Width = 8.0;
            t2.Height = 12.0;
            t2.Style = "right";

            Console.WriteLine("Info for t1 : ");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Area is : " + t1.Area());

            Console.WriteLine();

            Console.WriteLine("Info for t2 : ");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Area is : " + t2.Area());

            Console.ReadLine();
        }
    }
}
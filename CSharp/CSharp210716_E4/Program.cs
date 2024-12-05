using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp200716_E4
{
    //A class for two dimensional shape
    class TwoDShape
    {
        double pri_Width;
        double pri_Height;

        //Default Constructor
        public TwoDShape()
        {
            Width = Height = 0.0;
        }

        //Constructor for TwoDShape
        public TwoDShape(double w, double h)
        {
            Width = w;
            Height = h;
        }

        //Constructor for equal Width and Height
        public TwoDShape(double x)
        {
            Width = Height = x;
        }

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
        string Style; //private

        /* A default constructor. This automatically
           invokes the default constructor of TwoDShape */
        public Triangle()            
        {
            Style = "null";    //init the derived class
        }

        //Constructor
        public Triangle(string s, double w, double h) : base(w, h)
        {
            Style = s;    //init the derived class
        }

        //Constructor
        public Triangle(double x) : base(x)
        {
            Style = "isosceles";    //init the derived class
        }

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

    //Extended Triangle
    class ColorTriangle :Triangle
    {
        string Color;

        //Constructor
        public ColorTriangle(string c,string s, double w, double h) : base(s, w, h)
        {
            Color = c;    //init the derived class
        }

         //Display the color
        public void ShowColor()
        {
            Console.WriteLine("Color is " + Color);
        }
    }
    class Shapes
    {
        static void Main(string[] args)
        {
            ColorTriangle t1 = new ColorTriangle("Blue","right", 8.0, 12.0);

            ColorTriangle t2 = new ColorTriangle("Red","isoscales", 2.0, 2.0);

            Console.WriteLine("Info for t1 : ");
            t1.ShowStyle();
            t1.ShowDim();
            t1.ShowColor();
            Console.WriteLine("Area is : " + t1.Area());

            Console.WriteLine();

            Console.WriteLine("Info for t2 : ");
            t2.ShowStyle();
            t2.ShowDim();
            t2.ShowColor();
            Console.WriteLine("Area is : " + t2.Area());

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLecture
{
    class Rectangle
    {
        double length;
        double width;
        public void AcceptDetails()
        {
            Console.WriteLine("Enter Length:");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width:");
            width = Convert.ToDouble(Console.ReadLine());

        }
        public double GetArea()
        {

            return length * width;
        }
        public void Display()
        {
            double area = GetArea();
            Console.WriteLine("Area: {0}*{1}={2} ",length, width, area);
            Console.ReadKey();
        }

    }
    class InteractWithReactangle
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.AcceptDetails();
            rec.Display();
           
        }
    }
}

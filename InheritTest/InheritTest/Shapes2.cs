using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InheritTest
{
    class Shapes2
    {
        static void Main()
        {
            Triangle tr1 = new Triangle("isosceles", 4.0, 4.0);
            Triangle tr2 = new Triangle("right", 8.0, 12.0);

            tr1.Width = 4.0;
            tr1.Height = 4.0;
            tr1.Style = "isosceles";

            tr2.Width = 4.0;
            tr2.Height = 8.0;
            tr2.Style = "right";

            Console.WriteLine("Info for tr1: ");
            tr1.ShowStyle();
            tr1.ShowDim();
            Console.WriteLine("The Area of tr1 is: " + tr1.Area());

            Console.WriteLine("Info for tr2: ");
            tr2.ShowStyle();
            tr2.ShowDim();
            Console.WriteLine("The Area of tr2 is: " + tr2.Area());

            Console.ReadLine();

            Triangle tr3 = new Triangle("isosceles", 4.0, 4.0);
            Triangle tr4 = new Triangle("right", 8.0, 12.0);

            Console.WriteLine("Info for tr1: ");
            tr3.ShowStyle();
            tr3.ShowDim();
            Console.WriteLine("The Area of tr1 is: " + tr3.Area());

            Console.WriteLine("Info for tr2: ");
            tr4.ShowStyle();
            tr4.ShowDim();
            Console.WriteLine("The Area of tr2 is: " + tr4.Area());

            Console.ReadLine();


            NumberIuput nm = new NumberIuput();
            double width = 0;
            double height = 0;
            if (nm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                width = nm.Width;
                height = nm.Height;
            }
        }
    }
}

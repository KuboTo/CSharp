using System;

namespace InheritTest
{
    class TwoDShape
    {
        private double pri_width;
        private double pri_height;

        public TwoDShape(double w, double h)
        {
            this.Width = w;
            this.Height = h;
        }

        public double Width
        {
            get { return pri_width; }
            set { pri_width = value < 0 ? -value : value; }
        }

        public double Height
        {
            get { return pri_height; }
            set { pri_height = value < 0 ? -value : value; }
        }

        public void ShowDim()
        {
            Console.WriteLine("Width and Height are " + Width + " and " + Height);
        }
    }
}
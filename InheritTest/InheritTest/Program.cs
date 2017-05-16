using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritTest
{
    class Triangle : TwoDShape
    {
        public string Style;

        ///// <summary>
        ///// 构造函数（空的）
        ///// </summary>
        //public Triangle()
        //{
            
        //}

        ///// <summary>
        ///// 构造函数
        ///// </summary>
        ///// <param name="s"></param>
        ///// <param name="w"></param>
        ///// <param name="h"></param>
        //public Triangle(string s, double w, double h)
        //{
        //    this.Width = w;
        //    this.Height = h;
        //    this.Style = s;
        //}

        /// <summary>
        /// base关键字
        /// </summary>
        /// <param name="s"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        public Triangle(string s, double w, double h) : base(w, h)
        {
            Style = s;

        }

        public double Area()
        {
            return Width*Height/2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + Style);
        }
    }
}

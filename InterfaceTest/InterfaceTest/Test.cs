using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace InterfaceTest
{
    public class Test
    {
        public static void Main()
        {
            ByTwos ob = new ByTwos(1, 1);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Next value is " + ob.GetNext());
                
            }
            Console.ReadLine();

            ob.Reset();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Next value is " + ob.GetNext());

            }
            Console.ReadLine();

            ob.SetStart(100);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Next value is " + ob.GetNext());

            }
            Console.ReadLine();

            ob.SetStart(10);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Next value is " + ob.GetPrevious());

            }
            Console.ReadLine();


        }
    }
}

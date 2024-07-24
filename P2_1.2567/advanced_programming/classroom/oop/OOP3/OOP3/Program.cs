using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ractangle ractangle1 = new Ractangle(width: 50, height: -5);
            
            ractangle1.SetWidth(-5);
            ractangle1.SetHeight(50);

            Console.WriteLine("Width: " + ractangle1.GetWidth()); 
            Console.WriteLine("Height: " + ractangle1.GetHeight());
            Console.WriteLine("Ractangle = " + ractangle1.GetArea());

            Console.ReadLine();
        }
    }
}
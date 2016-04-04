using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();
            
            Shape shape1 = factory.getShape("circle");
            shape1.Draw();

            Shape shape2 = factory.getShape("rectangle");
            shape2.Draw();

            Shape shape3 = factory.getShape("triangle");
            shape3.Draw();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class ShapeFactory
    {
        public Shape getShape(String shape) {
            if(shape == "circle")
                return new Circle();
            if(shape == "rectangle")
                return new Rectangle();
            if(shape == "triangle")
                return new Triangle();
            else
                return null;
        }
    }
}

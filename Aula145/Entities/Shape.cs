using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula145.Entities.Enums;

namespace Aula145.Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
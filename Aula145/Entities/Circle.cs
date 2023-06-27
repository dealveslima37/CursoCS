using Aula145.Entities.Enums;

namespace Aula145.Entities
{
    internal class Circle : Shape
    {

        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
;        }
    }
}

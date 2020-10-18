using Entities.Enums;

namespace Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            this.Color = color;
        }

        public abstract double Area();
    }
}
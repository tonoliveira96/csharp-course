using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    class Retrangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Retrangle(double width, double height, Color color): base(color) { 
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}

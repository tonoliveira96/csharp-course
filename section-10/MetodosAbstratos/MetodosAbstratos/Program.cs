
using MetodosAbstratos.Entities;
using MetodosAbstratos.Entities.Enums;
using System.Globalization;

namespace MetodosAbstratos
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>();

            Console.WriteLine("Entre com número de figuras: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Figura #{i} data: ");
                Console.Write("Retangulo ou Circulo? (r/c): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Cor (Preto/Azul/Vermelho): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Altura: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Largura: ");
                    double height = double.Parse(Console.ReadLine());
                    shapes.Add(new Retrangle(width, height, color));
                }
                else
                {
                    Console.WriteLine("Raio: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Area das figuras: ");
            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

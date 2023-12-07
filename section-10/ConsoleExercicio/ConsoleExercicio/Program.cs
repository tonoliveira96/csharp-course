
using ConsoleExercicio.Entities;
using System.Globalization;

namespace ConsoleExercicio
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Emploee> employeeList = new List<Emploee>();
            Console.WriteLine("Entre com o número de funcionários: ");
            int employeesAmount = int.Parse(Console.ReadLine());


            for (int i = 0; i < employeesAmount; i++)
            {
                Console.WriteLine("Funcionário é terceirizado? (s/n)");
                string isOutsourced = Console.ReadLine();
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (isOutsourced == "s")
                {
                    Console.Write("Valor adiciona:");
                    double additionalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employeeList.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalValue));
                }
                else
                {
                    employeeList.Add(new Emploee(name, hours, valuePerHour));
                }

            }

            Console.WriteLine("_____PAGAMENTOS_______");
            foreach (Emploee emp in employeeList)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));

            }

        }
    }
}
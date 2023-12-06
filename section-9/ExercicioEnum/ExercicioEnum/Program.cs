using ExercicioEnum.Entities;
using ExercicioEnum.Entities.Enums;
using System.Globalization;

namespace ExercicioEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do departamento: ");
            string deptoName = Console.ReadLine();
            Console.WriteLine("Entre com os dados do Trabalhador: ");
            Console.Write("Nome:");
            string workerName = Console.ReadLine();
            Console.Write("Nível(Junior / MidLevel / Senior)':");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário base:");
            double workerBaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("__________________________________________________");

            Departament dept = new Departament(deptoName);
            Worker worker = new Worker(workerName, level, workerBaseSalary, dept);

            Console.WriteLine("Quanto contratos deseja cadastrar?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Entre com os dados do contrato #{i}:");
                Console.Write("Data (DD/MM/YYYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("valor por hora:");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração (horas):");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHours, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.WriteLine("Digite mês e ano para calcular os ganhos (MM/YYYY):");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departamento: " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
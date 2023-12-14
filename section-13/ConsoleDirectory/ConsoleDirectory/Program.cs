

namespace ConsoleDirectory
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";

            try
            {
                // Listar pastas
               IEnumerable<string> folder =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("PASTAS: ");
                foreach (string item in folder) { 
                    Console.WriteLine(item);
                }

                // Listar arquivos
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("ARQUIVOS: ");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                // Criar pastas
                Directory.CreateDirectory(path + @"\NewFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro.");
                Console.WriteLine(e.Message);
            }
        }
    }
}

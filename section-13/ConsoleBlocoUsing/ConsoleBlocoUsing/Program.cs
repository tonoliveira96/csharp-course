namespace ConsoleBlocoUsing
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
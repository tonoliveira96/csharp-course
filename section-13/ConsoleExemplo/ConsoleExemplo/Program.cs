namespace ConsoleExemplo
{
    class Program
    {
        public static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (var item in lines)
                {
                    Console.WriteLine(lines);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }
        }
    }
}

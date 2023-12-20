using Exemple.Extentions;
using System;

public class ProcessFile
{
    public static void Main()
    {
        DateTime dt = new DateTime(2023, 12, 19);
        Console.WriteLine(dt.ElapsedTime());
    }
}
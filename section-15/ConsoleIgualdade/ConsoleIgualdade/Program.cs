﻿using ConsoleIgualdade.Entities;

namespace ConsoleIgualdade
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("LapTop", 1500.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("LapTop", 1500.0);
            Console.WriteLine(a.Contains(prod));

            Point point = new Point(3, 4);
            Console.WriteLine(b.Contains(point));
        }
    }
}
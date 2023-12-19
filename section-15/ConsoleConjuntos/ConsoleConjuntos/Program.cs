namespace ConsoleConjuntos
{
    class Program
    {
        public static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>() { 1, 5, 6, 7, 78, 2, 8 };
            HashSet<int> b = new HashSet<int>() { 0, 1, 8, 14, 55 };

            // UNION
            SortedSet<int> c = new SortedSet<int>(a);
            c.Union(b);
            PrintCollection(c);

            // INTERCECTION
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            // DIFFERENCE
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(d);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
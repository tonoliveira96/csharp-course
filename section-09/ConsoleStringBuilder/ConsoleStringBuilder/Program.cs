using ConsoleStringBuilder.Entities;

namespace ConsoleStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment comment1 = new Comment("Tenha uma boa viajem!");
            Comment comment2 = new Comment("Quel lindo!");

            Post post1 = new Post(
                DateTime.Parse("16/07/2023 13:05:00"),
                "Viagem Tiradentes-MG",
                "Um pouco das minhas férias.",
                124
            );

            post1.AddComment(comment1);
            post1.AddComment(comment2);

            Comment comment3 = new Comment("Tenha uma boa viajem!");
            Comment comment4 = new Comment("AMo praia!");

            Post post2 = new Post(
                DateTime.Parse("03/10/2023 13:05:00"),
                "Viagem Arrail do Cabo - RJ",
                "Um pouco das minhas férias de novo.",
                120
            );

            post2.AddComment(comment3);
            post2.AddComment(comment4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);
        }
    }
}

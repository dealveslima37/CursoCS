using Aula131.Entities;

namespace Aula131;

class Program
{
    static void Main(string[] args)
    {

        var comment1 = new Comment { TEXT = "Tenha uma boa viagem" };
        var comment2 = new Comment { TEXT = "Wow isso é demais" };

        var post1 = new Post
        {
            Moment = DateTime.Parse("21/06/2018 13:05:44"),
            Title = "Viajem para nova zelândia",
            Content = "Estou indo visitar esse maravilhoso país",
            Likes = 12,
        };

        post1.AddComment(comment1);
        post1.AddComment(comment2);

        var post2 = new Post
        {
            Moment = DateTime.Parse("28/07/2018 23:14:19"),
            Title = "Boa noite caras",
            Content = "Vejo você amanhã",
            Likes = 5
        };

        post2.AddComment(new Comment { TEXT = "Boa noite" });
        post2.AddComment(new Comment { TEXT = "Que a força esteja com você" });

        Console.WriteLine(post1);
        Console.WriteLine(post2);

    }
}



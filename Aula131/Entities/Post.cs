using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula131.Entities
{
    internal class Post
    {

        public DateTime Moment { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; private set; } = new();

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.AppendLine($"{Likes} Likes - {Moment}");
            sb.AppendLine(Content);
            sb.AppendLine("Comentários");
            foreach (var comment in Comments)
            {
                sb.AppendLine(comment.TEXT);
            }

            return sb.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RedeSocial.Entities
{
    class Post
    {
        public int Likes { get; private set; }
        public DateTime Moment { get; private set; }
        public string Content { get; private set; }
        public string Title { get; private set; }

        public List<Comment> Comments { get; private set; } = new List<Comment>();

        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            this.Likes = likes;
            this.Moment = moment;
            this.Content = content;
            this.Title = title;
        }

        public override string ToString()
        {
            //utilizado para imprimir uma string com muitos dados
            //melhora muito a performace
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append($"\t{Likes}");
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine($"\t{Content}");
            sb.AppendLine("\nComments: ");

            foreach(Comment c in Comments)
            {
                sb.AppendLine($"\t{c.Text}");
            }
            return sb.ToString();
        }

        public void AddComment(params Comment[] comment)
        {
            foreach (Comment c in comment)
            {
                Comments.Add(c);
            }
        }
        public void RemoveComment(params Comment[] comment)
        {
            foreach (Comment c in comment)
            {
                Comments.Remove(c);
            }
        }
    }
}

namespace RedeSocial.Entities
{
    class Comment
    {
        public string Text { get; private set; }

        public Comment() { }
        public Comment(string texto)
        {
            this.Text = texto;
        }
        public override string ToString()
        {
            return this.Text;
        }
    }
}

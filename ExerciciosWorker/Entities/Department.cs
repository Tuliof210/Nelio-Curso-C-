namespace Empresa.Entities
{
    class Department
    {
        public string Name { get; private set; }

        public Department(){}
        public Department(string name) { this.Name = name; }

        public override string ToString()
        {
            return Name;
        }
    }
}

namespace ConsoleYieldApp.Entities
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Cpf { get; set; }

        public Person()
        {
            Id = Guid.NewGuid();
            Cpf = "";
        }

        public Person(string Cpf)
        {
            Id = Guid.NewGuid();
            this.Cpf = Cpf;
        }

    }
}

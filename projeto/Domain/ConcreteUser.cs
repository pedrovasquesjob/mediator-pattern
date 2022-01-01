namespace projeto.Domain
{
    public class ConcreteUser : User
    {
        public ConcreteUser(string name) : base(name)
        {
            
        }

        public override void Receive(string message)
        {
            System.Console.WriteLine($"{this.Name} - Mensagem recebida \n");
        }

        public override void Send(string message)
        {
            System.Console.WriteLine($"{this.Name} - Mensagem enviada \n");
            Mediator.SendMessage(message);
        }
    }
}
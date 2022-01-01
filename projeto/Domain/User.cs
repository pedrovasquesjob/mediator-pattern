using projeto.ConcreteMediator;

namespace projeto.Domain
{
    public abstract class User
    {
        protected Concrete Mediator;
        public string Name { get; private set; }

        protected User(string name)
        {
            Mediator = new Concrete();
            Name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
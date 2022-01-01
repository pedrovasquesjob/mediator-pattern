using projeto.ConcreteMediator;
using projeto.Domain;
using projeto.Mediator;

User Pedro = new ConcreteUser("Pedro");
User Paola = new ConcreteUser("Paola");

IMediator mediator = new Concrete();

mediator.RegisterUser(Pedro);
mediator.RegisterUser(Paola);

Pedro.Send("Estou aqui");
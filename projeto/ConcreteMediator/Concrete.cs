using projeto.Domain;
using projeto.Mediator;

namespace projeto.ConcreteMediator
{
    public class Concrete : IMediator
    {
        private List<User> Users = new List<User>();
        
        public void RegisterUser(User user)
        {
            Users.Add(user);
        }

        public void SendMessage(string message)
        {
            foreach(var user in Users)
            {
                user.Receive(message);
            }
        }
    }
}
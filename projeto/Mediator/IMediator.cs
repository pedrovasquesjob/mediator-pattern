using projeto.Domain;

namespace projeto.Mediator
{
    public interface IMediator
    {
        void SendMessage(string message);
        void RegisterUser(User user);
    }
}
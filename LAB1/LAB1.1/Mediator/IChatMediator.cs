namespace Study.Mediator;


public interface IMediator
{
  void RegisterUser(User sender);
  void SendMessage(string message, User sender);
}
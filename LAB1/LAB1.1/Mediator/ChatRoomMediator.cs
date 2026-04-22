namespace Study.Mediator;



public class ChatRoomMediator : IMediator
{
  private readonly List<User> _users = new();

  public void RegisterUser(User user)
  {
    ArgumentNullException.ThrowIfNull(user);

    _users.Add(user);
  }
  
  public void SendMessage(string message, User sender)
  {
    ArgumentNullException.ThrowIfNull(sender);

    foreach (var user in _users)
    {
      if (user != sender)
      {
        user.Recieve($"{sender.Name}: {message} \n");
      }
    }

  }
}
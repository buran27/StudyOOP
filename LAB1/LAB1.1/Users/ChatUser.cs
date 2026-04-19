using System;
using Study.Mediator;

namespace Study.Mediator;


public class ChatUser : User
{
  public ChatUser(string name, IMediator mediator) : base(name, mediator){}

  public override void Send(string message)
  {
    if (string.IsNullOrWhiteSpace(message))
      throw new ArgumentException("Message can't be empty.", nameof(message));

    Console.WriteLine($"{Name}: {message} \n");
    Mediator.SendMessage(message, this);
  }

  public override void Recieve(string message)
  {
    Console.WriteLine($"For {Name} from {message} \n");
  }
}
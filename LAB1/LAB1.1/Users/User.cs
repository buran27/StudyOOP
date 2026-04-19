namespace Study.Mediator;

public abstract class User
{
  public string Name {get;}
  protected IMediator Mediator {get;}

  protected User(string name, IMediator mediator)
  {
    if(string.IsNullOrWhiteSpace(name))
      throw new ArgumentException("Name can't be empty.", nameof(name));
    
    ArgumentNullException.ThrowIfNull(mediator);

    Name = name;
    Mediator = mediator;
  }

  public abstract void Send(string message);
  public abstract void Recieve(string message);
}
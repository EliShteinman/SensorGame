namespace SensorGame.Domain.Entities;

public abstract class InterrogationSensor : Isensor
{
  public abstract string Type { get; protected set; }
  public abstract void Activate();
  public InterrogationSensor(string type)
  {
    Type = type;
  }
}
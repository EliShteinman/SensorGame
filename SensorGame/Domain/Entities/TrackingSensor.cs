namespace SensorGame.Domain.Entities;

public abstract class TrackingSensor : Isensor
{
  public abstract string Type { get; protected set; }
  public abstract void Activate();
  public TrackingSensor(string type)
  {
    Type = type;
  }
}
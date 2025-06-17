namespace SensorGame.Domain.Entities;

public interface Isensor
{
  public string Type { get;}
  public void Activate();
}
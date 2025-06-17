namespace SensorGame.Domain.Entities;

public interface Isensor
{
	public string Name { get; }
	public string Type { get; }
	public void Activate();
}
namespace SensorGame.Domain.Entities;

public abstract class InterrogationSensor : Isensor
{
	public abstract string Name { get; protected set; }
	public string Type => "Interrogation";
	public abstract void Activate();
}
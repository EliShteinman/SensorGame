using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Interfaces;

public interface Isensor
{
	public SensorType Name { get; }
	public string Type { get; }
	
	public bool IsBroken { get; }
	public void Activate();
}
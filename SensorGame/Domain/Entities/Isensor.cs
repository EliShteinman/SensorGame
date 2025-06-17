using SensorGame.Domain.Enum;
namespace SensorGame.Domain.Entities;

public interface Isensor
{
	public SensorType Name { get; }
	public string Type { get; }
	
	public bool IsBroken { get; }
	public void Activate();
}
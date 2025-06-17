using SensorGame.Domain.Enum;
using SensorGame.Domain.Entities;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Interfaces;

public interface Isensor
{
	public SensorType Name { get; }
	public string Type { get; }
	
	public bool IsBroken { get; }
	public SensorExecutionResult Activate(IranAgent agent);
}
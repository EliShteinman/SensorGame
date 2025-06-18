using SensorGame.Domain.Entities.Sensors;
using SensorGame.Domain.Enum;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities;

public abstract class IranAgent
{
	protected readonly Sensor[] AttachedSensors;
	protected readonly SensorType[] Weaknesses;

	protected IranAgent(SensorType[] weaknesses)
	{
		Weaknesses = weaknesses;
		AttachedSensors = new Sensor[weaknesses.Length];
		IsExposed = false;
	}
	public abstract AgentRank Rank { get; }
	public bool IsExposed { get; protected set; }
	protected abstract InvestigationAggregateResult Investigate();

	public virtual InvestigationAggregateResult AttachSensor(Sensor sensor, int Location)
	{
		if (Location < 0 || Location >= AttachedSensors.Length)
		{
			throw new ArgumentException("Invalid Sensor location");
		}
		AttachedSensors[Location] = sensor;
		return Investigate();
	}
}
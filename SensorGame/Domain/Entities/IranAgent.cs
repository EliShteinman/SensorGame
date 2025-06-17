using SensorGame.Domain.Entities.Sensors;
using SensorGame.Domain.Enum;
using SensorGame.Domain.Interfaces;
using SensorGame.Domain.Models;
namespace SensorGame.Domain.Entities;

public abstract class IranAgent
{
	protected readonly Isensor[] AttachedSensors;
	protected readonly TrackingSensor[] Weaknesses;

	protected IranAgent(TrackingSensor[] weaknesses)
	{
		Weaknesses = weaknesses;
		AttachedSensors = new TrackingSensor[weaknesses.Length];
	}
	public abstract AgentRank Rank { get; }
	public bool IsExposed => false;
	protected abstract InvestigationAggregateResult Investigate();
	public virtual InvestigationAggregateResult AttachSensor(Isensor sensor, int Location)
	{
		switch (sensor)
		{
			case TrackingSensor track:
				if (Location < 0 || Location >= AttachedSensors.Length)
				{
					throw new ArgumentException("Invalid sensor location");
				}
				AttachedSensors[Location] = track;
				break;
			case InterrogationSensor interrogation:
				AttachedSensors[Location] = interrogation;
				break;
			default:
				throw new ArgumentException("Invalid sensor type");
		}
		return Investigate();
	}
}
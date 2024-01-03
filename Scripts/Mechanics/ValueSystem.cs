using System;

public partial class ValueSystem
{
	IGameStatsService gameStats = GameStatsService.Instance;
	public double GetCalculatedHealth()
	{	
		return 10 * Math.Pow(1.1, gameStats.GetPlanet(0).Level); 
	}
}

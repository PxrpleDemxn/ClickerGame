using Godot;
using System;
using System.Collections.Generic;

public partial interface IGameStatsService
{
	/// <summary>
	/// Adds coins
	/// </summary>
	/// <param name="coins">Coins</param>
	void AddCoins(double coins);

	/// <summary>
	/// Removes coins
	/// </summary>
	/// <param name="coins">Coins</param>
	void RemoveCoins(double coins);

	/// <summary>
	/// Sets coins
	/// </summary>
	/// <param name="coins">Coins</param>
	void SetCoins(double coins);

	/// <summary>
	/// Gets coins
	/// </summary>
	/// <returns>Coins</returns>
	double GetCoins();

	/// <summary>
	/// Sets calculated income
	/// </summary>
	/// <param name="income">Income</param>
	void SetIncome(double income);

	/// <summary>
	/// Gets calculated income
	/// </summary>
	/// <returns>Income</returns>
	double GetIncome();

	/// <summary>
	/// Sets hits per one click
	/// </summary>
	/// <param name="hitsPerClick">Coins per click</param>
	void SetHitsPerClick(double hitsPerClick);

	/// <summary>
	/// Gets current hits per one click
	/// </summary>
	/// <returns>hitsPerClick</returns>
	double GetHitsPerClick();

	/// <summary>
	/// Sets Game Stats
	/// </summary>
	/// <param name="gameStats">Game Stats</param>
	void SetGameStats(GameStats gameStats);

	/// <summary>
	/// Adds planet to list
	/// </summary>
	/// <param name="planet">Planet</param>
	void AddPlanet(Planet planet);

	/// <summary>
	/// Gets all planets in current system (rebirth)
	/// </summary>
	/// <returns>Planets</returns>
	List<Planet> GetPlanets();

	Planet GetPlanet(int index);

	/// <summary>
	/// Clears planet list to reset planets after rebirth
	/// </summary>
	void ClearPlanets();

	/// <summary>
	/// Adds one rebirth level
	/// </summary>
	void AddRebirthLevel();

	/// <summary>
	/// Gets rebirth level
	/// </summary>
	/// <returns>Rebirth Level</returns>
	int GetRebirthLevel();

	/// <summary>
	/// Gets GameStats
	/// </summary>
	/// <returns>GameStats</returns>
	GameStats GetGameStats();
}
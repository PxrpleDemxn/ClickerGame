using Godot;
using System;
using System.Collections.Generic;

public partial class GameStatsService : IGameStatsService
{
	private static GameStatsService _instance;
	private GameStats _gameStats;

	private GameStatsService()
	{
		_gameStats = new();
	}

	public static GameStatsService Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = new GameStatsService();
			}
			return _instance;
		}
	}

	public void AddCoins(double coins)
	{
		_gameStats.Coins += coins;
	}

	public void RemoveCoins(double coins)
	{
		_gameStats.Coins -= coins;
	}

	public double GetCoins()
	{
		return _gameStats.Coins;
	}

	public double GetIncome()
	{
		return _gameStats.Income;
	}

	public void SetCoins(double coins)
	{
		_gameStats.Coins = coins;
	}

	public void SetIncome(double income)
	{
		_gameStats.Income = income;
	}

	public void SetGameStats(GameStats gameStats)
	{
		_gameStats = gameStats;
	}

	public GameStats GetGameStats()
	{
		return _gameStats;
	}

	public void SetHitsPerClick(double hitsPerClick)
	{
		_gameStats.HitsPerClick = hitsPerClick;
	}

	public double GetHitsPerClick()
	{
		return _gameStats.HitsPerClick;
	}

	public void AddPlanet(Planet planet)
	{
		_gameStats.Planets.Add(planet);
	}

	public List<Planet> GetPlanets()
	{
		return _gameStats.Planets;
	}

	public void ClearPlanets()
	{
		_gameStats.Planets.Clear();
	}

	public void AddRebirthLevel()
	{
		_gameStats.RebirthLevel++;
	}

	public int GetRebirthLevel()
	{
		return _gameStats.RebirthLevel;
	}

    public Planet GetPlanet(int index)
    {
        return GetPlanets()[index];
    }

}

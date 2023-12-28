using Godot;
using System;

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

	public void SetCoinsPerClick(double coinsPerClick){
		_gameStats.CoinsPerClick = coinsPerClick;
	}

	public double GetCoinsPerClick(){
		return _gameStats.CoinsPerClick;
	}
}

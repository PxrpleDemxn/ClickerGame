using Godot;
using System;

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
	/// Sets coins per one click
	/// </summary>
	/// <param name="coinsPerClick">Coins per click</param>
	void SetCoinsPerClick(double coinsPerClick);

	/// <summary>
	/// Gets current coins per one click
	/// </summary>
	/// <returns>coinsPerClick</returns>
	double GetCoinsPerClick();

	/// <summary>
	/// Sets Game Stats
	/// </summary>
	/// <param name="gameStats">Game Stats</param>
	void SetGameStats(GameStats gameStats);

	/// <summary>
	/// Gets GameStats
	/// </summary>
	/// <returns>GameStats</returns>
	GameStats GetGameStats();
}
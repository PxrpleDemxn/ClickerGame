using Godot;
using System;
using System.Collections.Generic;

public interface ISaveService
{
	// TODO
	// Implement Save Game
	void SaveGame();

	/// <summary>
	/// Saves upgrades only
	/// </summary>
	/// <param name="upgrades">List of upgrades</param>
	void SaveUpgrades(List<Upgrade> upgrades);

	/// <summary>
	/// Loads all saved upgrades
	/// </summary>
	/// <returns>List of upgrades</returns>
	void LoadUpgrades();
}

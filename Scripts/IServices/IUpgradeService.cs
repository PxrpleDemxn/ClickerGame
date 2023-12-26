using Godot;
using System;
using System.Collections.Generic;

public interface IUpgradeService
{
	/// <summary>
	/// Gets all upgrades in list
	/// </summary>
	/// <returns>List of all upgrade objects</returns>
	List<Upgrade> GetUpgrades();

	/// <summary>
	/// Sets all upgrades to list
	/// </summary>
	/// <param name="upgrades">List of all upgrade objects</param>
	void SetUpgrades(List<Upgrade> upgrades);

	/// <summary>
	/// Adds upgrade to list
	/// </summary>
	/// <param name="upgrade">Upgrade</param>
	void AddUpgrade(Upgrade upgrade);

	/// <summary>
	/// Sets name of specific upgrade
	/// </summary>
	/// <param name="item">Upgrade model</param>
	/// <param name="name">Name</param>
	void SetName(Upgrade item, string name);

	/// <summary>
	/// Sets description of specific upgrade
	/// </summary>
	/// <param name="item">Upgrade model</param>
	/// <param name="desc">Description</param>
	void SetDescription(Upgrade item, string desc);

	/// <summary>
	/// Sets level of specific upgrade
	/// </summary>
	/// <param name="item">Upgrade model</param>
	/// <param name="level">Level</param>
	void SetLevel(Upgrade item, int level);

	/// <summary>
	/// Sets damage of specific upgrade
	/// </summary>
	/// <param name="item">Upgrade model</param>
	/// <param name="damage">Damage</param>
	void SetIncome(Upgrade item, long income);

	/// <summary>
	/// Gets price of specific upgrade
	/// </summary>
	/// <returns>Price</returns>
	long GetPrice();

	/// <summary>
	/// Sets price of specific upgrade
	/// </summary>
	/// <param name="price">Price</param>
	void SetPrice(long price);

	/// <summary>
	/// Creates dummy object for testing
	/// </summary>
	void CreateDummyUpgrade();

	/// <summary>
	/// Creates upgrade object
	/// </summary>
	/// <param name="name">Name</param>
	/// <param name="desc">Description</param>
	/// <param name="level">Level</param>
	/// <param name="income">Income</param>
	/// <param name="price">Price</param>
	void CreateUpgrade(string name, string desc, int level, double income, double price);
}

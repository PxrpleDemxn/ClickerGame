using Godot;
using System;
using System.Collections.Generic;

public partial class UpgradeService : IUpgradeService
{
	private List<Upgrade> _upgradeList;
	private static UpgradeService _instance;

	private UpgradeService()
	{
		_upgradeList = new();
	}

	public static UpgradeService Instance{
		get{
			if(_instance == null)
			{
				_instance = new UpgradeService();
			}
			return _instance;
		}
	}

	public List<Upgrade> GetUpgrades()
	{
		return _upgradeList;
	}

	public void SetUpgrades(List<Upgrade> upgrades)
    {
		// Sets parameter list to list we need
        _upgradeList = upgrades;
    }

	public void AddUpgrade(Upgrade upgrade)
	{
		_upgradeList.Add(upgrade);
	}

	public void SetIncome(Upgrade item, long income)
	{
		throw new NotImplementedException();
	}

	public void SetDescription(Upgrade item, string desc)
	{
		throw new NotImplementedException();
	}

	public void SetLevel(Upgrade item, int level)
	{
		throw new NotImplementedException();
	}

	public void SetName(Upgrade item, string name)
	{
		throw new NotImplementedException();
	}

    public long GetPrice()
    {
        throw new NotImplementedException();
    }

    public void SetPrice(long price)
    {
        throw new NotImplementedException();
    }

    public void CreateDummyUpgrade()
    {
		// Create Random class and Upgrade class
		Random rnd = new();
        Upgrade dummy = new();

		// Randomly set dummy variables
		dummy.Name = "Dummy"+rnd.Next(0,1000);
		dummy.Description = "Description";
		dummy.Level = rnd.Next(0,100);
		dummy.Income = rnd.Next(1000,10000);
		dummy.Price = rnd.Next(100,5000);

		// Add to list
		AddUpgrade(dummy);

		GD.Print("Dummy upgrade created: " + dummy.Name);
    }

	public void CreateUpgrade(string name, string desc, int level, double income, double price)
	{
		// Create Upgrade class
		Upgrade upgrade = new();

		// Set variables
		upgrade.Name = name;
		upgrade.Description = desc;
		upgrade.Level = level;
		upgrade.Income = income;
		upgrade.Price = price;

		// Add to list
		AddUpgrade(upgrade);
	}
}

using System.Collections.Generic;
using Godot;
using Newtonsoft.Json;

public partial class GameManager : Node
{
	private IUpgradeService _upgradeService = UpgradeService.Instance;
	//private ISaveService _saveService = new SaveService();
	public override void _Ready()
	{
		#region TESTING_ONLY
		// _upgradeService.CreateDummyUpgrade();
		// _upgradeService.CreateDummyUpgrade();
		// _upgradeService.CreateDummyUpgrade();

		//_saveService.LoadUpgrades();
		foreach (var item in _upgradeService.GetUpgrades())
		{
			GD.Print(item.Name);
		}
		#endregion
	}

	public override void _Process(double delta)
	{
	}
}

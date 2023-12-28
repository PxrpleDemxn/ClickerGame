using System.Collections.Generic;
using Godot;
using Newtonsoft.Json;

public partial class GameManager : Node
{
	private IUpgradeService _upgradeService = UpgradeService.Instance;
	private ISaveService _saveService = new SaveService();
	private IGameStatsService _gameStatsService = GameStatsService.Instance;
	public override void _Ready()
	{
		#region TESTING_ONLY

		LoadSaves();

		//  _upgradeService.CreateDummyUpgrade();
		//  _upgradeService.CreateDummyUpgrade();
		//  _upgradeService.CreateDummyUpgrade();

		// foreach (var item in _upgradeService.GetUpgrades())
		// {
		// 	GD.Print(item.Name);
		// }
		GD.Print(_gameStatsService.GetCoins());
		_gameStatsService.AddCoins(200);
		GD.Print(_gameStatsService.GetCoins());


		#endregion

				GetNode<Label>("GridContainer/HBoxContainer/MarginContainer/VBoxContainer/MarginContainer/GridContainer/PanelContainer/CoinsLabel").Text = _gameStatsService.GetCoins().ToString();
		GetNode<Label>("GridContainer/HBoxContainer/MarginContainer/VBoxContainer/MarginContainer/GridContainer/PanelContainer2/CoinsPerClickLabel").Text = "CPS: " + _gameStatsService.GetCoinsPerClick() + "/pc"; 

	}

	public override void _Process(double delta)
	{
		//Coins -> Shown in label 
		//GetNode<Label>("GridContainer/HBoxContainer/MarginContainer/VBoxContainer/MarginContainer/GridContainer/PanelContainer/CoinsLabel").Text = _gameStatsService.GetCoins().ToString();
		//GetNode<Label>("GridContainer/HBoxContainer/MarginContainer/VBoxContainer/MarginContainer/GridContainer/PanelContainer2/CoinsPerClickLabel").Text = "CPS: " + _gameStatsService.GetCoinsPerClick() + "/pc"; 
		//GetNode<Label>("GridContainer/HBoxContainer/MarginContainer/VBoxContainer/MarginContainer/GridContainer/PanelContainer3/PassiveIncomeLabel").Text = "Passive income: " + _gameStatsService.GetIncome() + "/sec";
	}

	// Saving when app is closed
	public override void _Notification(int what)
	{
		if (what == NotificationWMCloseRequest)
		{
			_saveService.SaveGameStats(_gameStatsService.GetGameStats());
			_saveService.SaveUpgrades(_upgradeService.GetUpgrades());
			GetTree().Quit();

		}

	}

	// Load all saves
	private void LoadSaves()
	{
		_saveService.LoadUpgrades();
		_saveService.LoadGameStats();
	}

	//

	public void _on_texture_button_pressed(){
		_gameStatsService.AddCoins(_gameStatsService.GetCoinsPerClick());
				GetNode<Label>("GridContainer/HBoxContainer/MarginContainer/VBoxContainer/MarginContainer/GridContainer/PanelContainer/CoinsLabel").Text = _gameStatsService.GetCoins().ToString();
		GetNode<Label>("GridContainer/HBoxContainer/MarginContainer/VBoxContainer/MarginContainer/GridContainer/PanelContainer2/CoinsPerClickLabel").Text = "CPS: " + _gameStatsService.GetCoinsPerClick() + "/pc"; 
	}

}

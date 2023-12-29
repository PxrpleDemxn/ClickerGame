using System.Collections.Generic;
using Godot;
using Newtonsoft.Json;

public partial class GameManager : Node
{
	[Export]
	Button clickToHitButton;
	[Export]
	Label coins,income,hitPerClick;

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

		_gameStatsService.SetHitsPerClick(1);

		#endregion


		// changed labels to display data from _gameservice - coins and coinsperclick
		coins.Text = _gameStatsService.GetCoins().ToString();
		hitPerClick.Text = "CPS: " + _gameStatsService.GetHitsPerClick() + "/pc"; 
		//income.Text = "Passive income: " + _gameStatsService.GetIncome() + "/sec";

		clickToHitButton.Pressed += enemyClickToHit_button_pressed;
	}

	public override void _Process(double delta)
	{
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

	public void enemyClickToHit_button_pressed(){
		_gameStatsService.AddCoins(_gameStatsService.GetHitsPerClick());
				coins.Text = _gameStatsService.GetCoins().ToString();
	}

}

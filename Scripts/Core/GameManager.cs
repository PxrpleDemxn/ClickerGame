using Godot;

public partial class GameManager : Node
{
	private IUpgradeService _upgradeService = UpgradeService.Instance;
	private ISaveService _saveService = new SaveService();
	private IGameStatsService _gameStatsService = GameStatsService.Instance;
	public override void _Ready()
	{
		#region TESTING_ONLY

		LoadSaves();
		LoadComponents();

		#endregion


	}

	public override void _Process(double delta)
	{
		// TODO Add income every second based on income value
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

	// Load components
	private void LoadComponents()
	{
		PackedScene upgradeList = GD.Load<PackedScene>("res://scenes/dynamic/list_of_upgrade_buttons.tscn");
		ScrollContainer upgradeScrlContainer = GetNode<ScrollContainer>("MainTest/MarginContainer/GameUIPanel/MarginContainer/HBoxContainer/UpgradesMenu/VBoxContainer/ScrollContainer");
		upgradeScrlContainer.AddChild(upgradeList.Instantiate());
	}
}

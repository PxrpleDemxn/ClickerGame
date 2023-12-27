using Godot;
using System;
using System.Collections.Generic;

public partial class DebugWindow : Node
{
	IUpgradeService upgradeService = UpgradeService.Instance;
	IGameStatsService gameStatsService = GameStatsService.Instance;
	ISaveService saveService = new SaveService();

	[Export]
	LineEdit nameEdit, descEdit, incomeEdit, priceEdit;
	[Export]
	VBoxContainer vBoxContainer;

	[Export]
	SpinBox _coinsSpinBox;
	[Export]
	Label lbl;
	int level = 0;

	public override void _Ready()
	{
		saveService.LoadUpgrades();
		saveService.LoadGameStats();
		RefreshList();
		lbl.Text = "Coins: " + gameStatsService.GetCoins();

	}
	// When button is pressed it will create Upgrade and it saves it to Upgrade list
	// After creating it will refresh list with all upgrades
	private void _on_button_pressed()
	{
		upgradeService.CreateUpgrade(nameEdit.Text, descEdit.Text, level, Convert.ToDouble(incomeEdit.Text), Convert.ToDouble(priceEdit.Text));
		saveService.SaveUpgrades(upgradeService.GetUpgrades());

		RefreshList();
	}

	private void _on_set_coins_pressed()
	{
		gameStatsService.AddCoins(_coinsSpinBox.Value);
		lbl.Text = "Coins: " + gameStatsService.GetCoins();
	}

		private void _on_set_coins_2_pressed()
	{
		if (_coinsSpinBox.Value < 0)
		{
			GD.Print("Value in spin box is lower than 0");
		} 
		gameStatsService.SetCoins(_coinsSpinBox.Value);
		lbl.Text = "Coins: " + gameStatsService.GetCoins();
	}

	private void _on_remove_coins_pressed()
	{
		if (gameStatsService.GetCoins() > _coinsSpinBox.Value)
		{
			gameStatsService.RemoveCoins(_coinsSpinBox.Value);
			lbl.Text = "Coins: " + gameStatsService.GetCoins();
		}
		else GD.Print("Value in spin box is higher than coins\nGame Coins: " + gameStatsService.GetCoins() + "\nValue in SpinBox: " + _coinsSpinBox.Value);
	}

	// Function for removing one upgrade from Upgrade list
	private void PressedButton(Upgrade upgrade)
	{
		upgradeService.GetUpgrades().Remove(upgrade);
		saveService.SaveUpgrades(upgradeService.GetUpgrades());

		RefreshList();
	}

	// Refreshing VBoxContainer with objects in Upgrade List
	private void RefreshList()
	{
		GD.Print(upgradeService.GetUpgrades().Count);
		// Removes all items in VBoxContainer
		foreach (var item in vBoxContainer.GetChildren())
		{
			item.QueueFree();
		}
		// Creates buttons in VBoxContainer and sets PressedButton function to each button
		foreach (Upgrade item in upgradeService.GetUpgrades())
		{
			Button btn = new Button
			{
				Text = item.Name

			};

			btn.Pressed += () => PressedButton(item);

			vBoxContainer.AddChild(btn);
		}
	}
}
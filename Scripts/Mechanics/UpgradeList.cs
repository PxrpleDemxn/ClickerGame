using Godot;
using System;

public partial class UpgradeList : Node
{
	IUpgradeService _upgradeService = UpgradeService.Instance;
	public override void _Ready()
	{
		// Get single upgrade scene
		PackedScene _scene = GD.Load<PackedScene>("res://scenes/dynamic/singular_upgrade_container.tscn");
		// Loop through all upgrades
		foreach (Upgrade item in _upgradeService.GetUpgrades())
		{
			// Get all needed obj references
			Node upgradeObj = _scene.Instantiate();
			Button upgradeButton = upgradeObj.GetNode<Button>("Upgrade/VBoxContainer/Upgrade_button");
			Label price = upgradeObj.GetNode<Label>("Upgrade/VBoxContainer/Upgrade_infoContainer/cost_label");
			RichTextLabel upgradeDesc = upgradeObj.GetNode<RichTextLabel>("Upgrade/VBoxContainer/upgrade_description");

			// Set needed variables to references
			upgradeButton.Text = item.Name;
			upgradeButton.Pressed += () => UpgradeClick(item);

			upgradeDesc.Text = item.Description;

			price.Text = "$" + item.Price.ToString();

			// Add to list scene
			AddChild(upgradeObj);
		}


	}

	// Handle buy function
	private void UpgradeClick(Upgrade upgrade)
	{
		GD.Print(upgrade.Name + " upgraded for " + upgrade.Price);
	}
}
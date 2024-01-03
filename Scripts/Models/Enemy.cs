using Godot;

public partial class Enemy
{
	/// <summary>
	/// Name
	/// </summary>
	public string Name { get; set; }
	/// <summary>
	/// Description
	/// </summary>
	public string Description { get; set; }
	
	/// <summary>
	/// Coins earned from sucessfully killing the enemy
	/// </summary>
	public double CoinsEarned { get; set; }

	/// <summary>
	/// Maximum health of the enemy
	/// </summary>
	public double MaxHealth { get; set; }
}
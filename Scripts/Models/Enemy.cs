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
	/// Current level
	/// </summary>
	public int Level { get; set; } // TODO Questionable - maybe the more enemies are killed the bigger their levels? Or on each planet a different level and the hp and income go from that?
	/// <summary>
	/// Coins earned from sucessfully killing the enemy
	/// </summary>
	public double CoinsEarned { get; set; }

	/// <summary>
	/// Maximum health of the enemy
	/// </summary>
	public double MaxHealth { get; set; }
    /// <summary>
    /// Current health of the enemy
    /// </summary>
    public double CurrentHealth { get; set; }
}
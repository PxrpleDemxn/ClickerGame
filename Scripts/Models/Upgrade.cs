public partial class Upgrade
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
	public int Level { get; set; }
	/// <summary>
	/// Current income
	/// </summary>
	public double Income { get; set; }

	/// <summary>
	/// Current price needed for new upgrade
	/// </summary>
	public double Price { get; set; }
}
using System.Collections.Generic;

public partial class GameStats
{
    /// <summary>
    /// Game Coins
    /// </summary>
    public double Coins { get; set; } = 0;

    /// <summary>
    /// Game Income
    /// </summary>
    public double Income { get; set; } = 0;

    /// <summary>
    /// Hits per one click
    /// </summary>
    public double HitsPerClick { get; set; } = 1;

    /// <summary>
    /// Planet Level
    /// </summary>
    public List<Planet> Planets {get;set;} = new();

    /// <summary>
    /// Rebirth Level
    /// </summary>
    public int RebirthLevel { get; set; } = 0;

}
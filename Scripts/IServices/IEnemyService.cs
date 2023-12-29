using Godot;
using System;

public partial interface IEnemyService{

/// <summary>
/// Sets the name of the enemy
/// </summary>
/// <param name="name">Name</param>
    void SetName(string name);
    /// <summary>
    /// Sets the description of the enemy
    /// </summary>
    /// <param name="desc">Description</param>
    void SetDescription(string desc);
    /// <summary>
    /// Sets the level of the enemy
    /// </summary>
    /// <param name="level">Level</param>
    void SetLevel(int level);
    /// <summary>
    /// Sets the coins you earn after defeating the enemy
    /// </summary>
    /// <param name="coinsEarned">Coins earned</param>
    void SetCoinsEarned(double coinsEarned);
    /// <summary>
    /// Sets the maximum health of the enemy
    /// </summary>
    /// <param name="maxHealth">Max health</param>
    void SetMaxHealth(double maxHealth);
    /// <summary>
    /// Sets the current health of the enemy
    /// </summary>
    /// <param name="currentHealth">Current health</param>
    void SetCurrentHealth(double currentHealth);

/// <summary>
/// Gets the name of the enemy
/// </summary>
/// <param name="name">Name</param>
    string GetName();
    /// <summary>
    /// Gets the description of the enemy
    /// </summary>
    /// <param name="desc">Description</param>
    string GetDescription();
    /// <summary>
    /// Gets the level of the enemy
    /// </summary>
    /// <param name="level">Level</param>
    int GetLevel();
    /// <summary>
    /// Gets the coins you earn after defeating the enemy
    /// </summary>
    /// <param name="coinsEarned">Coins earned</param>
    double GetCoinsEarned();
    /// <summary>
    /// Gets the maximum health of the enemy
    /// </summary>
    /// <param name="maxHealth">Max health</param>
    double GetMaxHealth();
    /// <summary>
    /// Gets the current health of the enemy
    /// </summary>
    /// <param name="currentHealth">Current health</param>
    double GetCurrentHealth();

}
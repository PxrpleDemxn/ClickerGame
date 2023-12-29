using Godot;
using System;
using System.Collections.Generic;

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

	/// <summary>
	/// Sets all upgrades to list
	/// </summary>
	/// <param name="enemies">List of all enemy objects</param>
	void SetEnemies(List<Enemy> enemies);

     /// <summary>
	/// Gets all enemies in list
	/// </summary>
	/// <returns>List of all enemy objects</returns>
	List<Enemy> GetEnemies();

    /// <summary>
	/// Adds enemy to list
	/// </summary>
	/// <param name="enemy">Enemy</param>
	void AddEnemy(Enemy enemy);
    
    /// <summary>
    /// Gets enemy from list on index
    /// </summary>
    /// <param name="index">index</param>
    /// <returns>single Enemy object</returns>
    Enemy GetEnemy(int index);

    /// <summary>
	/// Creates dummy object for testing
	/// </summary>
	void CreateDummyEnemy();
    /// <summary>
    /// Creates Enemy object
    /// </summary>
    /// <param name="name">Name</param>
    /// <param name="desc">Description</param>
    /// <param name="level">Level</param>
    /// <param name="coinsEarned">Coins Earned</param>
    /// <param name="maxHealth">Max Health</param>
    /// <param name="currentHealth">Current Health</param>
    void CreateEnemy(string name, string desc, int level, double coinsEarned, double maxHealth);

	

}
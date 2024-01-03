using Godot;
using System;
using System.Collections.Generic;

public partial class EnemyService : IEnemyService
{
private List<Enemy> _enemyList;
    private static EnemyService _instance;
	private Enemy _enemy;

	private EnemyService()
	{
		//_enemy = new();
        _enemyList = new();
	}

	public static EnemyService Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = new EnemyService();
			}
			return _instance;
		}
	}
            //Setters
    public void SetName(string name){
        _enemy.Name = name;
    }
    public void SetDescription(string desc){
        _enemy.Description = desc;
    }

    public void SetCoinsEarned(double coinsEarned){
        _enemy.CoinsEarned = coinsEarned;
    }
    public void SetMaxHealth(double maxHealth){
        _enemy.MaxHealth = maxHealth;
    }


            //Getters

    public string GetName(){
        return _enemy.Name;
    }
    public string GetDescription(){
        return _enemy.Description;
    }

    public double GetCoinsEarned(){
        return _enemy.CoinsEarned;
    }

    public double GetMaxHealth(){
        return _enemy.MaxHealth;
    }




    public List<Enemy> GetEnemies()
	{
		return _enemyList;
	}

    public void SetEnemies(List<Enemy> enemies)
    {
		// Sets parameter list to list we need
        _enemyList = enemies;
    }

	public void AddEnemy(Enemy enemy)
	{
		_enemyList.Add(enemy);
	}

    public Enemy GetEnemy(int index){
        return _enemyList[index];
    }

    public void CreateDummyEnemy()
    {
		// Create Random class and Upgrade class
		Random rnd = new();
        Enemy dummy = new();

		// Randomly set dummy variables
		dummy.Name = "Dummy"+rnd.Next(0,1000);
		dummy.Description = "Description";
		dummy.CoinsEarned = rnd.Next(1,100);
		dummy.MaxHealth = rnd.Next(10,20);

		// Add to list
		AddEnemy(dummy);

        GD.Print(
        "Dummy enemy created: " + dummy.Name + "\n" +
        "Desc: " + dummy.Description + "\n" +
        "CoinsEarned: " + dummy.CoinsEarned + "\n" +
        "Max Health: " + dummy.MaxHealth + "\n"
        );
    }

	public void CreateEnemy(string name, string desc, int level, double coinsEarned, double maxHealth)
	{
		// Create Enemy class
		Enemy enemy = new();

		// Set variables
		enemy.Name = name;
		enemy.Description = desc;
		enemy.CoinsEarned = coinsEarned;
		enemy.MaxHealth = maxHealth;

		// Add to list
		AddEnemy(enemy);
	}

    public void SetLevel(int level)
    {
        throw new NotImplementedException();
    }

    public void SetCurrentHealth(double currentHealth)
    {
        throw new NotImplementedException();
    }

    public int GetLevel()
    {
        throw new NotImplementedException();
    }

    public double GetCurrentHealth()
    {
        throw new NotImplementedException();
    }

}
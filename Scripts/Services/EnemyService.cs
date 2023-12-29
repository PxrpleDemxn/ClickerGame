using Godot;
using System;

public partial class EnemyService : IEnemyService
{

    private static EnemyService _instance;
	private Enemy _enemy;

	private EnemyService()
	{
		_enemy = new();
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
    public void SetLevel(int level){
        _enemy.Level = level;
    }
    public void SetCoinsEarned(double coinsEarned){
        _enemy.CoinsEarned = coinsEarned;
    }
    public void SetMaxHealth(double maxHealth){
        _enemy.MaxHealth = maxHealth;
    }
    public void SetCurrentHealth(double currentHealth){
        _enemy.CurrentHealth = currentHealth;
    }

            //Getters

    public string GetName(){
        return _enemy.Name;
    }
    public string GetDescription(){
        return _enemy.Description;
    }
    public int GetLevel(){
        return _enemy.Level;
    }
    public double GetCoinsEarned(){
        return _enemy.CoinsEarned;
    }

    public double GetMaxHealth(){
        return _enemy.MaxHealth;
    }

    public double GetCurrentHealth(){
        return _enemy.CurrentHealth;
    }
}
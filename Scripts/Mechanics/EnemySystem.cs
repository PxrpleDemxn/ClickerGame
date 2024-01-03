using System;
using System.ComponentModel.DataAnnotations;
using Godot;

public partial class EnemySystem : Node
{
    IGameStatsService gameStatsService = GameStatsService.Instance;
    
    ISaveService save = new SaveService();
    [Export] public PanelContainer _panelContainer;
    [Export] public ProgressBar progressBar;
    [Export] 	ItemList enemyList;
    [Export] Label enemyCount;
    private double _currentHealth, _maxHealth;
    ValueSystem valueSystem = new ValueSystem();

    public double MaxHealth
    {
        get
        {
            return _maxHealth;
        }
        set
        {
            _maxHealth = value;
        }
    }
    public override void _Ready()
    {
        save.LoadGameStats();
        						enemyCount.Text = gameStatsService.GetPlanet(0).EnemyKills.ToString();
		for (int i = 1; i < gameStatsService.GetPlanet(0).Level+1; i++)
		{
				enemyList.AddItem("Enemy lvl: " + i);
		}

        Spawn();
    }

    public void Hit()
    {
        GD.Print("Hit!");
        _currentHealth -= gameStatsService.GetHitsPerClick();
        progressBar.Value = _currentHealth;

        if (IsDead())
        {
            gameStatsService.GetPlanet(0).EnemyKills++;
            if(gameStatsService.GetPlanet(0).EnemyKills == 10)
            {
                gameStatsService.GetPlanet(0).Level++;
                gameStatsService.GetPlanet(0).EnemyKills=0;
                				enemyList.AddItem("Enemy lvl: " + gameStatsService.GetPlanet(0).Level.ToString());


            }

            foreach (var item in _panelContainer.GetChildren())
            {
                item.QueueFree();
            }
						enemyCount.Text = gameStatsService.GetPlanet(0).EnemyKills.ToString();

            Spawn();
                        
        }
    }

    private bool IsDead()
    {
        if (_currentHealth <= 0) return true;
        else return false;
    }

    public void Spawn()
    {

        MaxHealth = valueSystem.GetCalculatedHealth();

        Button hitButton = new();
        TextureRect enemyImage = new TextureRect
        {
            Texture = GD.Load<Texture2D>(EnemyConstants.Enemy1)
        };

        hitButton.FocusMode = Control.FocusModeEnum.None;
        hitButton.Pressed += Hit;
        hitButton.MouseFilter = Control.MouseFilterEnum.Stop;

        _currentHealth = _maxHealth;

        progressBar.Value = _currentHealth;
        progressBar.MaxValue = _maxHealth;

        _panelContainer.AddChild(enemyImage);
        _panelContainer.AddChild(hitButton);
        GD.Print(_maxHealth);
    }
}
using Godot;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

public partial class SaveService : ISaveService
{
  IUpgradeService _upgradeService = UpgradeService.Instance;
  IGameStatsService _gameStats = GameStatsService.Instance;

  IEnemyService _enemy = EnemyService.Instance;
  const string path = "res://test.json"; // path, change it later!!
  const string savePath = "res://save000.json"; // savePath, change it later!!

  const string enemySavePath = "res://enemies.json"; // enemySavePath, change it later!!
  public void SaveGame()
  {
    // TODO
    // Implement save game
  }

  public void SaveUpgrades(List<Upgrade> upgrades)
  {
    // Opens path and sets flag to write
    using var save = FileAccess.Open(path, FileAccess.ModeFlags.Write);
    // Using Newtonsoft.Json we serialize object to automatically convert it to json
    string json = JsonConvert.SerializeObject(_upgradeService.GetUpgrades());
    // Saves json file to path
    save.StoreLine(json);
  }

  public void LoadUpgrades()
  {
    // Opens path and sets flag to read
    using var load = FileAccess.Open(path, FileAccess.ModeFlags.Read);
    // Checks if load file exists... if not it create new empty List<Upgrade>
    if (load == null)
    {
      _upgradeService.SetUpgrades(new List<Upgrade>());
      return;
    }
    // Using Newtonsoft.Json we deserialize object to automatically convert it back to List<Upgrade>
    _upgradeService.SetUpgrades(JsonConvert.DeserializeObject<List<Upgrade>>(load.GetLine()));
  }

  public void SaveGameStats(GameStats gameStats)
  {
    // Opens path and sets flag to write
    using var save = FileAccess.Open(savePath, FileAccess.ModeFlags.Write);

    // Using Newtonsoft.Json we serialize object to automatically convert it to json
    string json = JsonConvert.SerializeObject(gameStats);

    // Saves json file to path
    save.StoreLine(json);
  }

  public void LoadGameStats()
  {
    // Opens path and sets flag to read
    using var load = FileAccess.Open(savePath, FileAccess.ModeFlags.Read);

    // Checks if load file exists... if not it create new empty GameStats
    if (load == null)
    {
      _gameStats.SetGameStats(new GameStats());
      return;
    }

    // Using Newtonsoft.Json we deserialize object to automatically convert it back to GameStats
    _gameStats.SetGameStats(JsonConvert.DeserializeObject<GameStats>(load.GetLine()));
  }

  public void SaveEnemy(Enemy enemy)
  {
    // Opens path and sets flag to write
    using var save = FileAccess.Open(enemySavePath, FileAccess.ModeFlags.Write);
    
    // Using Newtonsoft.Json we serialize object to automatically convert it to json
    string json = JsonConvert.SerializeObject(_enemy.GetEnemies());

    save.StoreLine(json);

  }

  public void LoadEnemy(){
    // Opens path and sets flag to read
    using var load = FileAccess.Open(enemySavePath, FileAccess.ModeFlags.Read);
    // Checks if load file exists... if not it create new empty List<Enemy>
    if (load == null)
    {
      _enemy.SetEnemies(new List<Enemy>());
      return;
    }
    // Using Newtonsoft.Json we deserialize object to automatically convert it back to List<Enemy>
    _enemy.SetEnemies(JsonConvert.DeserializeObject<List<Enemy>>(load.GetLine()));
  }

}
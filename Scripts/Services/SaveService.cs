using Godot;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

public partial class SaveService : ISaveService
{
  IUpgradeService _upgradeService = UpgradeService.Instance;
  string path = "res://test.json"; // path, change it later!!
  public void SaveGame()
  {
    // TODO
    // Implement save game
    throw new NotImplementedException();
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
}

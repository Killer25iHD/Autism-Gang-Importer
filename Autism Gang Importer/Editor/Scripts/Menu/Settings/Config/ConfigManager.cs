using System;
using System.IO;
using Unity.Plastic.Newtonsoft.Json;
using UnityEngine;

namespace AutismImporter.Settings.Config
{
    public class ConfigManager
    {
        private static readonly string ConfigFolderPath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AutismGangImporter");
        private static ConfigManager _instance;
        private static readonly object _lock = new();
        private static readonly string ConfigFilePath = Path.Combine(ConfigFolderPath, "config.json");
        
        private ConfigManager()
        {
            LoadConfig();
        }
        public static ConfigManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null) _instance = new ConfigManager();
                }

                return _instance;
            }
        }

        public ConfigModel Config { get; private set; }

        private void LoadConfig()
        {
            try
            {
                if (File.Exists(ConfigFilePath))
                {
                    var json = File.ReadAllText(ConfigFilePath);
                    Config = JsonConvert.DeserializeObject<ConfigModel>(json);
                }
                else
                {
                    Config = new ConfigModel();
                    SaveConfig();
                }
            }
            catch (IOException ex)
            {
                Debug.LogError($"Could not load config: {ex.Message}");
            }
        }

        private void SaveConfig()
        {
            try
            {
                Directory.CreateDirectory(ConfigFolderPath);
                var json = JsonConvert.SerializeObject(Config, Formatting.Indented);
                File.WriteAllText(ConfigFilePath, json);
            }
            catch (IOException ex)
            {
                Debug.LogError($"Could not save config: {ex.Message}");
            }
        }

        public void UpdateConfig(Action<ConfigModel> updateAction)
        {
            updateAction?.Invoke(Config);
            SaveConfig();
        }
    }
}
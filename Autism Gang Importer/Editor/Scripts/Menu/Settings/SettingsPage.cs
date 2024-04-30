using AutismImporter.Settings.Config;
using Discord;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AutismImporter.Settings
{
    public class SettingsPage : EditorWindow
    {
        
        public static void ShowSettings()
        {
            CreateGUI();
        }
        // ReSharper disable Unity.PerformanceAnalysis
        private static void CreateGUI()
        {
            SeperatorHelper.DrawSeparators(4);
            
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUI.backgroundColor = Color.black;
            GUILayout.EndHorizontal();
            GUILayout.BeginVertical("Settings", "window", GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
            var discordEnabled = ConfigManager.Instance.Config.DiscordSetting.Enabled;
            GUILayout.BeginHorizontal();


            #region Toggle Design

            //design
            var toggleStyle = new GUIStyle(GUI.skin.button);
            var discordText = "";
            if(discordEnabled)
            {
                discordText = "DiscordRPC is Enabled";
            }
            else
            {
                toggleStyle.normal.textColor = Color.red;
                toggleStyle.hover.textColor = Color.red;
                discordText = "DiscordRPC is Disabled";
                AutismGangMenu.DestroySpecificGameObjects("AutismGangDiscord");
            }
            //end design

            #endregion
            discordEnabled = GUILayout.Toggle(discordEnabled, discordText, toggleStyle);
            
            ConfigManager.Instance.UpdateConfig(config => config.DiscordSetting.Enabled = discordEnabled);
            GUILayout.EndHorizontal();

            GUILayout.EndVertical();
        }
    }
}
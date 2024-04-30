using UnityEditor;
using UnityEngine;

namespace AutismImporter.Settings
{
    public class SettingsPage : EditorWindow
    {
        public static void ShowSettings()
        {
            CreateGUI();
        }

        private static void CreateGUI()
        {
            
            SeperatorHelper.DrawSeparators(4);
            
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.Space(20);
            GUI.backgroundColor = Color.black;
            GUILayout.BeginVertical("Settings", "window", GUILayout.Height(240), GUILayout.Width(340));


            SeperatorHelper.DrawSpace(15);
        }
    }
}
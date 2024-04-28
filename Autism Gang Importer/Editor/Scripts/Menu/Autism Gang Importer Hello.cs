using System.IO;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

namespace AutismImporter
{
    public partial class AutismGangMenu : EditorWindow
    {
        private Texture _helloImage;
        private const string GameObjectName = "AutismGangDiscord";
        private const string DiscordDllRelativePath = "Autism-Gang-Importer/Autism Gang Importer/DiscordGameSDK/Dependencies/discord_game_sdk.dll";
        
        private const string Message1 = "Thank you for using the Autism Gang Importer!";
        private const string Message2 = "If you have any questions,\nplease be sure to ask the Admins or Mods of our Discord First!\nThank you for your Appreciation! ♥";
        private const string Message3 = "If you have any Feedback,\nplease be sure to reach out to the Admins or Mods of our Discord.♥";
        
        private string DiscordDllPath => Path.Combine(Application.dataPath, DiscordDllRelativePath);
        

        private void OnEnable()
        {
            CheckDiscordDll();
            EnsureDiscordControllerExists();
        }    

        private void CheckDiscordDll()
        {
            if (File.Exists(DiscordDllPath))
            {
                SetDllDirectory(DiscordDllPath);
            }
            else
            {
                Debug.LogWarning($"Discord DLL path does not exist: {DiscordDllPath}");
            }
        }


        private static void EnsureDiscordControllerExists()
        {
            if (!GameObject.Find(GameObjectName))
            {
                var gameObjectToAttachTo = new GameObject(GameObjectName);
                gameObjectToAttachTo.AddComponent<DiscordController>();
            }
        }

        private void OnDestroy()
        {
            DestroySpecificGameObjects("AutismGangDiscord");
            DiscordController.Dispose();
        }

        private void DestroySpecificGameObjects(string targetName)
        {
            var gameObjects = FindObjectsOfType<GameObject>();
            foreach (var gameObject in gameObjects)
            {
                if (gameObject.name == targetName)
                {
                    DestroyImmediate(gameObject);
                }
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetDllDirectory(string lpPathName);

        private void ShowHello()
        {
            string[] messages = { Message1, Message2, Message3 };
            
            for (var i = 0; i < 4; i++)
            {
                EditorGUILayout.Separator();
            }

            GUI.backgroundColor = Color.red;
            DrawGUI(messages);

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Made by: LoseMyXelf");
            EditorGUILayout.EndHorizontal();
        }
        
        private void DrawGUI(string[] messages)
        {
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.Space(20);

            GUILayout.BeginVertical("Welcome", "window", GUILayout.Height(240), GUILayout.Width(340));
            foreach (var message in messages)
            {
                GUILayout.Space(20);
                EditorGUILayout.BeginHorizontal();
                GUILayout.Label(message);
                EditorGUILayout.EndHorizontal();
            }

            for (int i = 0; i < 15; i++)
            {
                EditorGUILayout.Space();
            }

            GUILayout.EndVertical();
            GUILayout.Space(20);
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }
    }
}
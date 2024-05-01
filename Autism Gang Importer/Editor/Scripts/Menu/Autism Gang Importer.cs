using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutismImporter.Settings.Config;
using UnityEditor;
using UnityEngine;

namespace AutismImporter
{
    public partial class AutismGangMenu : EditorWindow
    {
        private static Vector2 changeLogScroll;

        private Task DownloadAndImportPackage(Uri unitypakcageURL)
        {
            try
            {
                var tempPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                               "/temp.unitypackage";
                if (File.Exists(tempPath)) File.Delete(tempPath);
                using (var wc = new WebClient())
                {
                    wc.DownloadFileAsync(unitypakcageURL, tempPath);
                    wc.DownloadProgressChanged += WcOnDownloadProgressChanged;
                    wc.DownloadFileCompleted += WcOnDownloadFileCompleted;
                }

                EditorUtility.ClearProgressBar();
            }
            catch (Exception e)
            {
                Debug.LogError($"Error downloading package: {e.Message}");
                throw;
            }

            return Task.CompletedTask;
        }

        private void WcOnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            var tempPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                           "/temp.unitypackage";
            EditorUtility.ClearProgressBar();
            AssetDatabase.ImportPackage(tempPath, false);
            File.Delete(tempPath);
            EditorUtility.DisplayDialog("Download Complete",
                "The package has been downloaded and imported successfully!", "OK");
            AssetDatabase.Refresh();
        }

        private void WcOnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            var tempPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                           "/temp.unitypackage";
            var progress = e.ProgressPercentage;
            var cancelBar = EditorUtility.DisplayCancelableProgressBar("Downloading package...",
                $"Downloading package... {progress}%", progress / 100f);
            if (cancelBar)
            {
                EditorUtility.ClearProgressBar();
                if (File.Exists(tempPath)) File.Delete(tempPath);
                EditorUtility.DisplayDialog("Download Cancelled", "The download has been cancelled.", "OK");
            }
        }

        private void ShowImport()
        {
            GUI.backgroundColor = Color.black;
            var textStyleBlack = new GUIStyle(EditorStyles.textField);
            textStyleBlack.normal.textColor = Color.white;
            var miniButtonStyleGreen = new GUIStyle(EditorStyles.miniButton);
            miniButtonStyleGreen.normal.textColor = Color.green;
            var textStyleMagenta = new GUIStyle(EditorStyles.textField);
            textStyleMagenta.normal.textColor = Color.magenta;

            changeLogScroll = GUILayout.BeginScrollView(changeLogScroll, false, false, GUIStyle.none,
                GUI.skin.verticalScrollbar, GUILayout.Width(520));
            GUI.backgroundColor = Color.black;


            //Sorts Category and Items Correctly
            var groups = ConfigManager
                .Instance.Config.Importables.Importables
                .OrderBy(i => i.Category)
                .GroupBy(i => i.Category);

            #region Design

            var headerStyle = new GUIStyle(GUI.skin.label)
            {
                fontSize = 16,
                alignment = TextAnchor.MiddleCenter,
                fontStyle = FontStyle.Bold,
                normal = { textColor = Color.white }
            };

            var importableStyle = new GUIStyle(GUI.skin.label)
            {
                fontSize = 12,
                alignment = TextAnchor.MiddleLeft,
                normal = { textColor = Color.white }
            };

            var buttonStyle = new GUIStyle(GUI.skin.button)
            {
                fontSize = 12,
                fontStyle = FontStyle.Bold,
                normal = { textColor = Color.white }
            };

            #endregion

            foreach (var group in groups)
            {
                GUILayout.BeginVertical(GUI.skin.box);
                GUILayout.Space(10);
                GUILayout.Label($"{group.Key.ToString()}", headerStyle);

                foreach (var importable in group)
                {
                    GUILayout.Space(10);
                    GUILayout.BeginHorizontal();
                    GUILayout.Label($"{importable.Name}", importableStyle);

                    if (GUILayout.Button("Import", buttonStyle, GUILayout.Width(100), GUILayout.Height(30)))
                        DownloadAndImportPackage(importable.Uri);
                    GUILayout.EndHorizontal();
                }

                GUILayout.Space(10);
                GUILayout.EndVertical();
                GUILayout.Space(25);
            }

            GUILayout.EndScrollView();
        }
    }
}
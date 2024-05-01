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

        private readonly Uri Anim =
            new("https://cloud.nohobbysfound.net/s/rRtpA8SLRqoF9tJ/download/MyXelf.unitypackage");

        private readonly Uri Anim2 =
            new("https://cloud.nohobbysfound.net/s/QNimeREs4F5nMck/download/Hackervr.unitypackage");

        private readonly Uri Ark =
            new("https://cloud.nohobbysfound.net/s/AMwitdjPq3GDxe2/download/arktoon-shaders-1.0.2.6.unitypackage");

        private readonly Uri Aud =
            new(
                "https://cloud.nohobbysfound.net/s/5ATXMccs3W2kpSD/download/World%20Audio%20Prefab%20-by%20killer.unitypackage");

        private readonly Uri BTK =
            new("https://cloud.nohobbysfound.net/s/nPKSBzyemLMtndS/download/GVAS_BetterKeyframing3.unitypackage");

        private readonly Uri Burn =
            new(
                "https://cloud.nohobbysfound.net/s/FDrmfDxFmArSgpx/download/Doppelganger_Burning_Glasses_v1.1.unitypackage");

        private readonly Uri Cry =
            new("https://cloud.nohobbysfound.net/s/73nMdgRTb4LQFWQ/download/Crystal_Shader.unitypackage");

        private readonly Uri Doc = new("https://cloud.nohobbysfound.net/s/3MC6dX3n4FAo9fS/download/DocMe.unitypackage");

        private readonly Uri Dope =
            new("https://cloud.nohobbysfound.net/s/poSReeCBsRwxx7C/download/Dope_v1.unitypackage");

        private readonly Uri Dope2 =
            new(
                "https://cloud.nohobbysfound.net/s/wDa7BNDGtyLtJgB/download/Doppelganger_Patreon_Dope_Shader_2.3.1.unitypackage");

        private readonly Uri DPS =
            new(
                "https://cloud.nohobbysfound.net/s/aHGXr8NPf4Pd7Kd/download/RalivDynamicPenetrationSystemV1_31%281%29.unitypackage");

        private readonly Uri Hum =
            new("https://cloud.nohobbysfound.net/s/mgfzrHD6mbjC9XT/download/GVAS_HumanoidSpeedKeyframing.unitypackage");

        private readonly Uri Lev =
            new(
                "https://cloud.nohobbysfound.net/s/bSMenLBpbwEQ5Wr/download/Leviant_ScreenSpace_Ubershader_v2.9.unitypackage");

        // Other URL variables...

        private readonly Uri Lol =
            new("https://cloud.nohobbysfound.net/s/TnbLQC39PRo6LSb/download/Loli_Eye_Shader.unitypackage");

        private readonly Uri Math =
            new(
                "https://cloud.nohobbysfound.net/s/CzwWPS2sPHaCpLk/download/90Hz%20Equation%20Shader%20v1.0.unitypackage");

        private readonly Uri Met =
            new("https://cloud.nohobbysfound.net/s/ZqHwT94PbG7tPsJ/download/MetallicFX_v5.0.unitypackage");

        private readonly Uri Muscle =
            new("https://cloud.nohobbysfound.net/s/rsqetPwGHHLMcGH/download/MuscleAnimator.unitypackage");

        private readonly Uri Nek =
            new("https://cloud.nohobbysfound.net/s/oXpPERjFQwsk934/download/NEK0s_Payed_Eye_Shader_v5.unitypackage");

        private readonly Uri Overrender =
            new(
                "https://cloud.nohobbysfound.net/s/XqaAEHtwG6rNiHc/download/2023LyzeOverrenderFamilyV5%282%29.unitypackage");

        private readonly Uri Part =
            new(
                "https://cloud.nohobbysfound.net/s/jFaZQwszQnjCCBs/download/Simple%20Hand%20Particles%20Prefab%20-by%20killer.unitypackage");

        private readonly Uri PoH =
            new("https://cloud.nohobbysfound.net/s/LR9rL3M3c7Es6Kn/download/PoH_3D%281%29.unitypackage");

        private readonly Uri Q =
            new("https://cloud.nohobbysfound.net/s/QSCnHJgXQWDF44S/download/QHierarchy%20Fix.unitypackage");

        private readonly Uri QOTT =
            new("https://cloud.nohobbysfound.net/s/jSE9AiEJe9X6jMZ/download/Question%20Of%20The%20Time.unitypackage");

        private readonly Uri Sp =
            new(
                "https://cloud.nohobbysfound.net/s/SmonSSr7WoQdNMG/download/Simple%20Overrender%20Sphere%20-by%20killer.unitypackage");

        private readonly Uri Tog =
            new("https://cloud.nohobbysfound.net/s/9PaDqtKgLtgjp3A/download/ToggleAssistant-0.11.0.unitypackage");

        private readonly Uri Tool =
            new("https://cloud.nohobbysfound.net/s/t55tPjjbjm2nxYY/download/GVAS-AnimationTools-July26.unitypackage");

        private readonly Uri toon =
            new("https://cloud.nohobbysfound.net/s/oRzsMBdjS6ti6LG/download/poi_Toon_7.3.50_UpTo_9.0.56.unitypackage");

        private readonly Uri Uni =
            new(
                "https://cloud.nohobbysfound.net/s/cBezM7GrHLE22oX/download/Doppelganger_Best_Universe_Within_v1.01%281%29.unitypackage");

        private readonly Uri Yu =
            new("https://cloud.nohobbysfound.net/s/KcAz6ZETRS2wioq/download/Yukios_Fur_Shader_1.unitypackage");

        private Uri cryy = new("https://cloud.nohobbysfound.net/s/kctBtatR6Mtk2iG/download/Cry_by_killer.unitypackage");

        private Uri Fin =
            new("https://cloud.nohobbysfound.net/s/rzdGiWGyGHsz9Zd/download/Final_IK_v1.9_Stub.unitypackage");

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
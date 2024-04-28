using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading.Tasks;
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
                var tempPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/temp.unitypackage";
                if(File.Exists(tempPath))
                {
                    File.Delete(tempPath);
                }
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
            var tempPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/temp.unitypackage";
            EditorUtility.ClearProgressBar();
            AssetDatabase.ImportPackage(tempPath, false);
            File.Delete(tempPath);
            EditorUtility.DisplayDialog("Download Complete", "The package has been downloaded and imported successfully!", "OK");
            AssetDatabase.Refresh();
        }

        private void WcOnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            var tempPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/temp.unitypackage";
            var progress = e.ProgressPercentage;
            var cancelBar = EditorUtility.DisplayCancelableProgressBar("Downloading package...", $"Downloading package... {progress}%", progress / 100f);
            if (cancelBar)
            {
                EditorUtility.ClearProgressBar();
                if(File.Exists(tempPath))
                {
                    File.Delete(tempPath);
                }
                EditorUtility.DisplayDialog("Download Cancelled", "The download has been cancelled.", "OK");
            }
        }

        void ShowImport()
        {
            GUI.backgroundColor = Color.black;
            GUIStyle a = new GUIStyle(EditorStyles.textField);
            a.normal.textColor = Color.white;
            GUIStyle c = new GUIStyle(EditorStyles.miniButton);
            c.normal.textColor = Color.green;
            GUIStyle b = new GUIStyle(EditorStyles.textField);
            b.normal.textColor = Color.magenta;
            GUIStyle d = new GUIStyle(EditorStyles.textField);
            d.normal.textColor = Color.black;

            changeLogScroll = GUILayout.BeginScrollView(changeLogScroll, false, false, GUIStyle.none, GUI.skin.verticalScrollbar, GUILayout.Width(520));
            GUI.backgroundColor = Color.black;
            GUILayout.Space(15);
            GUI.backgroundColor = Color.black;
            GUILayout.Label("                                                                   Avatar Shader", a);

            GUILayout.BeginHorizontal();
            GUI.backgroundColor = Color.white;
            if (GUILayout.Button("Poiyomi Toon v 9.0.34"))
            {
                DownloadAndImportPackage(toon);
            }
            GUILayout.EndHorizontal();
            GUI.backgroundColor = Color.white;
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Loli Eye Shader"))
            {
                DownloadAndImportPackage(Lol);
            }
            if (GUILayout.Button("Arktoon Shaders 1.0.2"))
            {
                DownloadAndImportPackage(Ark);
            }
            if (GUILayout.Button("Metallic FX v 5.0"))
            {
                DownloadAndImportPackage(Met);
            }
            GUILayout.EndHorizontal();

            GUILayout.Space(20);
            GUI.backgroundColor = Color.black;
            GUILayout.Label("                                                              Other Avatar Shader", a);

            GUILayout.BeginHorizontal();
            GUI.backgroundColor = Color.white;
            if (GUILayout.Button("Burning Glasses Shader"))
            {
                DownloadAndImportPackage(Burn);
            }
            if (GUILayout.Button("Question of the Time"))
            {
                DownloadAndImportPackage(QOTT);
            }
            if (GUILayout.Button("Crystal"))
            {
                DownloadAndImportPackage(Cry);
            }
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUI.backgroundColor = Color.white;
            if (GUILayout.Button("90 Hz Math Shader"))
            {
                DownloadAndImportPackage(Math);
            }
            if (GUILayout.Button("Nek0s Payed Eye Shader v5"))
            {
                DownloadAndImportPackage(Nek);
            }
            if (GUILayout.Button("Yukikos Fur Shader"))
            {
                DownloadAndImportPackage(Yu);
            }
            GUILayout.EndHorizontal();

            GUILayout.Space(20);
            GUI.backgroundColor = Color.black;
            GUILayout.Label("                                                                Some Cancer Shader", a);

            GUILayout.BeginHorizontal();
            GUI.backgroundColor = Color.white;
            if (GUILayout.Button("DocMe"))
            {
                DownloadAndImportPackage(Doc);
            }
            if (GUILayout.Button("Leviant v 2.9"))
            {
                DownloadAndImportPackage(Lev);
            }
            if (GUILayout.Button("Dope v1"))
            {
                DownloadAndImportPackage(Dope);
            }
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUI.backgroundColor = Color.white;
            if (GUILayout.Button("Dope v 2.3.1"))
            {
                DownloadAndImportPackage(Dope2);
            }
            if (GUILayout.Button("Universe"))
            {
                DownloadAndImportPackage(Uni);
            }
            if (GUILayout.Button("PoH 3D"))
            {
                DownloadAndImportPackage(PoH);
            }
            GUILayout.EndHorizontal();

            GUILayout.Space(20);
            GUI.backgroundColor = Color.black;
            GUILayout.Label("                                                                  Some Usefull Shit", a);

            GUILayout.BeginHorizontal();
            GUI.backgroundColor = Color.white;
            if (GUILayout.Button("DPS"))
            {
                DownloadAndImportPackage(DPS);
            }
            if (GUILayout.Button("Muscle Animator"))
            {
                DownloadAndImportPackage(Muscle);
            }
            if (GUILayout.Button("QHierarchy Fix"))
            {
                DownloadAndImportPackage(Q);
            }
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUI.backgroundColor = Color.white;
            if (GUILayout.Button("Toggle Maker Assistant"))
            {
                DownloadAndImportPackage(Tog);
            }
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUI.backgroundColor = Color.white;
            if (GUILayout.Button("Overrenderer by lyze"))
            {
                DownloadAndImportPackage(Overrender);
            }
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUI.backgroundColor = Color.white;
            if (GUILayout.Button("HumanoidSpeed "))
            {
                DownloadAndImportPackage(Hum);
            }
            if (GUILayout.Button("GVAS Anim Tools"))
            {
                DownloadAndImportPackage(Tool);
            }
            if (GUILayout.Button("Better Keyframing 3"))
            {
                DownloadAndImportPackage(BTK);
            }
            GUILayout.EndHorizontal();

            GUILayout.Space(20);
            GUI.backgroundColor = Color.black;
            GUILayout.Label("                                                                           Prefabs", a);

            GUILayout.BeginHorizontal();
            GUI.backgroundColor = Color.white;
            if (GUILayout.Button("World Audio by killer"))
            {
                DownloadAndImportPackage(Aud);
            }
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUI.backgroundColor = Color.white;
            if (GUILayout.Button("Simple Hand Particles by killer"))
            {
                DownloadAndImportPackage(Part);
            }
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUI.backgroundColor = Color.white;
            if (GUILayout.Button("Simple Overrender Sphere by killer"))
            {
                DownloadAndImportPackage(Sp);
            }
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUI.backgroundColor = Color.white;
            if (GUILayout.Button("Cry fixed by killer"))
            {
                DownloadAndImportPackage(Sp);
            }
            GUILayout.EndHorizontal();

            GUILayout.Space(20);
            GUI.backgroundColor = Color.black;
            GUILayout.Label("                                                                             Idles", a);

            GUILayout.BeginHorizontal();
            GUI.backgroundColor = Color.white;
            if (GUILayout.Button("MyXelf"))
            {
                DownloadAndImportPackage(Anim);
            }
            if (GUILayout.Button("HackerVR / DocMe"))
            {
                DownloadAndImportPackage(Anim2);
            }
            GUILayout.EndHorizontal();




            GUILayout.EndScrollView();
        }

        // Other URL variables...

        private Uri Lol = new Uri("https://cloud.nohobbysfound.net/s/TnbLQC39PRo6LSb/download/Loli_Eye_Shader.unitypackage");
        private Uri Ark = new Uri("https://cloud.nohobbysfound.net/s/AMwitdjPq3GDxe2/download/arktoon-shaders-1.0.2.6.unitypackage");
        private Uri Met = new Uri("https://cloud.nohobbysfound.net/s/ZqHwT94PbG7tPsJ/download/MetallicFX_v5.0.unitypackage");

        private Uri Burn = new Uri("https://cloud.nohobbysfound.net/s/FDrmfDxFmArSgpx/download/Doppelganger_Burning_Glasses_v1.1.unitypackage");
        private Uri QOTT = new Uri("https://cloud.nohobbysfound.net/s/jSE9AiEJe9X6jMZ/download/Question%20Of%20The%20Time.unitypackage");
        private Uri Cry = new Uri("https://cloud.nohobbysfound.net/s/73nMdgRTb4LQFWQ/download/Crystal_Shader.unitypackage");

        private Uri Math = new Uri("https://cloud.nohobbysfound.net/s/CzwWPS2sPHaCpLk/download/90Hz%20Equation%20Shader%20v1.0.unitypackage");
        private Uri Nek = new Uri("https://cloud.nohobbysfound.net/s/oXpPERjFQwsk934/download/NEK0s_Payed_Eye_Shader_v5.unitypackage");
        private Uri Yu = new Uri("https://cloud.nohobbysfound.net/s/KcAz6ZETRS2wioq/download/Yukios_Fur_Shader_1.unitypackage");

        private Uri Doc = new Uri("https://cloud.nohobbysfound.net/s/3MC6dX3n4FAo9fS/download/DocMe.unitypackage");
        private Uri Lev = new Uri("https://cloud.nohobbysfound.net/s/bSMenLBpbwEQ5Wr/download/Leviant_ScreenSpace_Ubershader_v2.9.unitypackage");
        private Uri Dope = new Uri("https://cloud.nohobbysfound.net/s/poSReeCBsRwxx7C/download/Dope_v1.unitypackage");

        private Uri Dope2 = new Uri("https://cloud.nohobbysfound.net/s/wDa7BNDGtyLtJgB/download/Doppelganger_Patreon_Dope_Shader_2.3.1.unitypackage");
        private Uri PoH = new Uri("https://cloud.nohobbysfound.net/s/LR9rL3M3c7Es6Kn/download/PoH_3D%281%29.unitypackage");
        private Uri Uni = new Uri("https://cloud.nohobbysfound.net/s/cBezM7GrHLE22oX/download/Doppelganger_Best_Universe_Within_v1.01%281%29.unitypackage");

        private Uri Muscle = new Uri("https://cloud.nohobbysfound.net/s/rsqetPwGHHLMcGH/download/MuscleAnimator.unitypackage");
        private Uri DPS = new Uri("https://cloud.nohobbysfound.net/s/aHGXr8NPf4Pd7Kd/download/RalivDynamicPenetrationSystemV1_31%281%29.unitypackage");
        private Uri Fin = new Uri("https://cloud.nohobbysfound.net/s/rzdGiWGyGHsz9Zd/download/Final_IK_v1.9_Stub.unitypackage");

        private Uri Q = new Uri("https://cloud.nohobbysfound.net/s/QSCnHJgXQWDF44S/download/QHierarchy%20Fix.unitypackage");
        private Uri Tog = new Uri("https://cloud.nohobbysfound.net/s/9PaDqtKgLtgjp3A/download/ToggleAssistant-0.11.0.unitypackage");
        private Uri Aud = new Uri("https://cloud.nohobbysfound.net/s/5ATXMccs3W2kpSD/download/World%20Audio%20Prefab%20-by%20killer.unitypackage");

        private Uri Part = new Uri("https://cloud.nohobbysfound.net/s/jFaZQwszQnjCCBs/download/Simple%20Hand%20Particles%20Prefab%20-by%20killer.unitypackage");
        private Uri Sp = new Uri("https://cloud.nohobbysfound.net/s/SmonSSr7WoQdNMG/download/Simple%20Overrender%20Sphere%20-by%20killer.unitypackage");
        private Uri Anim = new Uri("https://cloud.nohobbysfound.net/s/rRtpA8SLRqoF9tJ/download/MyXelf.unitypackage");

        private Uri Anim2 = new Uri("https://cloud.nohobbysfound.net/s/QNimeREs4F5nMck/download/Hackervr.unitypackage");
        private Uri BTK = new Uri("https://cloud.nohobbysfound.net/s/nPKSBzyemLMtndS/download/GVAS_BetterKeyframing3.unitypackage");
        private Uri Hum = new Uri("https://cloud.nohobbysfound.net/s/mgfzrHD6mbjC9XT/download/GVAS_HumanoidSpeedKeyframing.unitypackage");
        
        private Uri Tool = new Uri("https://cloud.nohobbysfound.net/s/t55tPjjbjm2nxYY/download/GVAS-AnimationTools-July26.unitypackage");
        private Uri toon = new Uri("https://cloud.nohobbysfound.net/s/oRzsMBdjS6ti6LG/download/poi_Toon_7.3.50_UpTo_9.0.56.unitypackage");
        private Uri cryy = new Uri("https://cloud.nohobbysfound.net/s/kctBtatR6Mtk2iG/download/Cry_by_killer.unitypackage");
        private Uri Overrender = new Uri("https://cloud.nohobbysfound.net/s/XqaAEHtwG6rNiHc/download/2023LyzeOverrenderFamilyV5%282%29.unitypackage");
        //private string string name here = "";

        // Add more URL varables as needed...
    }
}

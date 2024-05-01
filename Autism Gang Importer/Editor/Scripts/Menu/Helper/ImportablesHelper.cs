using System;
using System.Collections;
using System.Linq;
using AutismImporter.Settings.Config;

namespace AutismImporter.Helper
{
    public class ImportablesHelper
    {
        private static readonly Uri Anim =
            new("https://cloud.nohobbysfound.net/s/rRtpA8SLRqoF9tJ/download/MyXelf.unitypackage");

        private static readonly Uri Anim2 =
            new("https://cloud.nohobbysfound.net/s/QNimeREs4F5nMck/download/Hackervr.unitypackage");

        private static readonly Uri Ark =
            new("https://cloud.nohobbysfound.net/s/AMwitdjPq3GDxe2/download/arktoon-shaders-1.0.2.6.unitypackage");

        private static readonly Uri Aud =
            new(
                "https://cloud.nohobbysfound.net/s/5ATXMccs3W2kpSD/download/World%20Audio%20Prefab%20-by%20killer.unitypackage");

        private static readonly Uri BTK =
            new("https://cloud.nohobbysfound.net/s/nPKSBzyemLMtndS/download/GVAS_BetterKeyframing3.unitypackage");

        private static readonly Uri Burn =
            new(
                "https://cloud.nohobbysfound.net/s/FDrmfDxFmArSgpx/download/Doppelganger_Burning_Glasses_v1.1.unitypackage");

        private static readonly Uri Cry =
            new("https://cloud.nohobbysfound.net/s/73nMdgRTb4LQFWQ/download/Crystal_Shader.unitypackage");

        private static readonly Uri Doc =
            new("https://cloud.nohobbysfound.net/s/3MC6dX3n4FAo9fS/download/DocMe.unitypackage");

        private static readonly Uri Dope =
            new("https://cloud.nohobbysfound.net/s/poSReeCBsRwxx7C/download/Dope_v1.unitypackage");

        private static readonly Uri Dope2 =
            new(
                "https://cloud.nohobbysfound.net/s/wDa7BNDGtyLtJgB/download/Doppelganger_Patreon_Dope_Shader_2.3.1.unitypackage");

        private static readonly Uri DPS =
            new(
                "https://cloud.nohobbysfound.net/s/aHGXr8NPf4Pd7Kd/download/RalivDynamicPenetrationSystemV1_31%281%29.unitypackage");

        private static readonly Uri Hum =
            new("https://cloud.nohobbysfound.net/s/mgfzrHD6mbjC9XT/download/GVAS_HumanoidSpeedKeyframing.unitypackage");

        private static readonly Uri Lev =
            new(
                "https://cloud.nohobbysfound.net/s/bSMenLBpbwEQ5Wr/download/Leviant_ScreenSpace_Ubershader_v2.9.unitypackage");

        private static readonly Uri Lol =
            new("https://cloud.nohobbysfound.net/s/TnbLQC39PRo6LSb/download/Loli_Eye_Shader.unitypackage");

        private static readonly Uri Math =
            new(
                "https://cloud.nohobbysfound.net/s/CzwWPS2sPHaCpLk/download/90Hz%20Equation%20Shader%20v1.0.unitypackage");

        private static readonly Uri Met =
            new("https://cloud.nohobbysfound.net/s/ZqHwT94PbG7tPsJ/download/MetallicFX_v5.0.unitypackage");

        private static readonly Uri Muscle =
            new("https://cloud.nohobbysfound.net/s/rsqetPwGHHLMcGH/download/MuscleAnimator.unitypackage");

        private static readonly Uri Nek =
            new("https://cloud.nohobbysfound.net/s/oXpPERjFQwsk934/download/NEK0s_Payed_Eye_Shader_v5.unitypackage");

        private static readonly Uri Overrender =
            new(
                "https://cloud.nohobbysfound.net/s/XqaAEHtwG6rNiHc/download/2023LyzeOverrenderFamilyV5%282%29.unitypackage");

        private static readonly Uri Part =
            new(
                "https://cloud.nohobbysfound.net/s/jFaZQwszQnjCCBs/download/Simple%20Hand%20Particles%20Prefab%20-by%20killer.unitypackage");

        private static readonly Uri PoH =
            new("https://cloud.nohobbysfound.net/s/LR9rL3M3c7Es6Kn/download/PoH_3D%281%29.unitypackage");

        private static readonly Uri Q =
            new("https://cloud.nohobbysfound.net/s/QSCnHJgXQWDF44S/download/QHierarchy%20Fix.unitypackage");

        private static readonly Uri QOTT =
            new("https://cloud.nohobbysfound.net/s/jSE9AiEJe9X6jMZ/download/Question%20Of%20The%20Time.unitypackage");

        private static readonly Uri Sp =
            new(
                "https://cloud.nohobbysfound.net/s/SmonSSr7WoQdNMG/download/Simple%20Overrender%20Sphere%20-by%20killer.unitypackage");

        private static readonly Uri Tog =
            new("https://cloud.nohobbysfound.net/s/9PaDqtKgLtgjp3A/download/ToggleAssistant-0.11.0.unitypackage");

        private static readonly Uri Tool =
            new("https://cloud.nohobbysfound.net/s/t55tPjjbjm2nxYY/download/GVAS-AnimationTools-July26.unitypackage");

        private static readonly Uri toon =
            new("https://cloud.nohobbysfound.net/s/oRzsMBdjS6ti6LG/download/poi_Toon_7.3.50_UpTo_9.0.56.unitypackage");

        private static readonly Uri Uni =
            new(
                "https://cloud.nohobbysfound.net/s/cBezM7GrHLE22oX/download/Doppelganger_Best_Universe_Within_v1.01%281%29.unitypackage");

        private static readonly Uri Yu =
            new("https://cloud.nohobbysfound.net/s/KcAz6ZETRS2wioq/download/Yukios_Fur_Shader_1.unitypackage");

        private static readonly Uri cryy =
            new("https://cloud.nohobbysfound.net/s/kctBtatR6Mtk2iG/download/Cry_by_killer.unitypackage");

        private Uri Fin =
            new("https://cloud.nohobbysfound.net/s/rzdGiWGyGHsz9Zd/download/Final_IK_v1.9_Stub.unitypackage");

        public static void LoadImportables()
        {
            ConfigManager.Instance.UpdateConfig(config => config.Importables.Importables.Clear());
            var categorysHash = new Hashtable
            {
                //AvatarShader
                { "Poiyomi Toon v 9.0.34", Categorys.AvatarShader },
                { "Loli Eye Shader", Categorys.AvatarShader },
                { "Arktoon Shaders 1.0.2", Categorys.AvatarShader },
                { "Metallic FX v 5.0", Categorys.AvatarShader },
                //OtherAvatarShader
                { "Burning Glasses Shader", Categorys.OtherAvatarShader },
                { "Question of the Time", Categorys.OtherAvatarShader },
                { "Crystal", Categorys.OtherAvatarShader },
                { "90 Hz Math Shader", Categorys.OtherAvatarShader },
                { "Nek0s Payed Eye Shader v5", Categorys.OtherAvatarShader },
                { "Yukikos Fur Shader", Categorys.OtherAvatarShader },
                //SomeCancerShader
                { "DocMe", Categorys.SomeCancerShader },
                { "Leviant v 2.9", Categorys.SomeCancerShader },
                { "Dope v1", Categorys.SomeCancerShader },
                { "Dope v 2.3.1", Categorys.SomeCancerShader },
                { "Universe", Categorys.SomeCancerShader },
                { "PoH 3D", Categorys.SomeCancerShader },
                //SomeUsefullShit
                { "DPS", Categorys.SomeUsefullShit },
                { "Muscle Animator", Categorys.SomeUsefullShit },
                { "QHierarchy Fix", Categorys.SomeUsefullShit },
                { "Toggle Maker Assistant", Categorys.SomeUsefullShit },
                { "Overrenderer by lyze", Categorys.SomeUsefullShit },
                { "HumanoidSpeed", Categorys.SomeUsefullShit },
                { "GVAS Anim Tools", Categorys.SomeUsefullShit },
                { "Better Keyframing 3", Categorys.SomeUsefullShit },
                //Prefabs
                { "Simple Hand Particles", Categorys.Prefabs },
                { "Simple Overrender Sphere", Categorys.Prefabs },
                { "World Audio", Categorys.Prefabs },
                { "Cry fixed", Categorys.Prefabs },
                //Idles
                { "MyXelf", Categorys.Idles },
                { "HackerVR / DocMe", Categorys.Idles }
            };
            var importablesHash = new Hashtable
            {
                //AvatarShader
                { "Poiyomi Toon v 9.0.34", toon },
                { "Loli Eye Shader", Lol },
                { "Arktoon Shaders 1.0.2", Ark },
                { "Metallic FX v 5.0", Met },
                //OtherAvatarShader
                { "Burning Glasses Shader", Burn },
                { "Question of the Time", QOTT },
                { "Crystal", Cry },
                { "90 Hz Math Shader", Math },
                { "Nek0s Payed Eye Shader v5", Nek },
                { "Yukikos Fur Shader", Yu },
                //SomeCancerShader
                { "DocMe", Doc },
                { "Leviant v 2.9", Lev },
                { "Dope v1", Dope },
                { "Dope v 2.3.1", Dope2 },
                { "Universe", Uni },
                { "PoH 3D", PoH },
                //SomeUsefullShit
                { "DPS", DPS },
                { "Muscle Animator", Muscle },
                { "QHierarchy Fix", Q },
                { "Toggle Maker Assistant", Tog },
                { "Overrenderer by lyze", Overrender },
                { "HumanoidSpeed", Hum },
                { "GVAS Anim Tools", Tool },
                { "Better Keyframing 3", BTK },
                //Prefabs
                { "Simple Hand Particles", Part },
                { "Simple Overrender Sphere", Sp },
                { "World Audio", Aud },
                { "Cry fixed", cryy },
                //Idles
                { "MyXelf", Anim },
                { "HackerVR / DocMe", Anim2 }
            };

            foreach (var importableItem in from DictionaryEntry entry in importablesHash
                     select new ImportableItem
                     {
                         Name = entry.Key.ToString(),
                         Uri = (Uri)entry.Value,
                         Category = (Categorys)categorysHash[entry.Key.ToString()]
                     })
                ConfigManager.Instance.UpdateConfig(config => config.Importables.Importables.Add(importableItem));
        }
    }
}
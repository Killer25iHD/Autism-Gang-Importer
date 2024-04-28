using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace AutismImporter
{

    public partial class AutismGangMenu : EditorWindow
    {
        

        [MenuItem("𝓐𝓾𝓽𝓲𝓼𝓶 𝓖𝓪𝓷𝓰/𝓱𝓮𝓵𝓹/𝓜𝔂   𝓓𝓲𝓼𝓬𝓸𝓻𝓭")]
        public static void ShowVRChatDiscord()
        {
            Application.OpenURL("https://discord.gg/N6jvJDGnsM");
        }

        [MenuItem("𝓐𝓾𝓽𝓲𝓼𝓶 𝓖𝓪𝓷𝓰/𝓱𝓮𝓵𝓹/𝓓𝓮𝓿 𝓕𝓐𝓠")]
        public static void ShowDeveloperFAQ()
        {
            Application.OpenURL("https://hello.vrchat.com/developer-faq");
        }

        [MenuItem("𝓐𝓾𝓽𝓲𝓼𝓶 𝓖𝓪𝓷𝓰/𝓱𝓮𝓵𝓹/𝓜𝔂 𝓦𝓮𝓫𝓼𝓲𝓽𝓮")]
        public static void ShowMyWebsite()
        {
            Application.OpenURL("http://losemyxelf.xyz");
        }

        [MenuItem("𝓐𝓾𝓽𝓲𝓼𝓶 𝓖𝓪𝓷𝓰/𝓱𝓮𝓵𝓹/𝓜𝔂 𝓕𝓸𝓻𝓾𝓶")]
        public static void ShowMyForum()
        {
            Application.OpenURL("http://forum.losemyxelf.xyz");
        }

        [MenuItem("𝓐𝓾𝓽𝓲𝓼𝓶 𝓖𝓪𝓷𝓰/𝓱𝓮𝓵𝓹/𝓓𝓸𝔀𝓷𝓵𝓸𝓪𝓭 𝓷𝓮𝔀𝓮𝓼𝓽 𝓥𝓮𝓻𝓼𝓲𝓸𝓷")]
        public static void ShowUpdate()
        {
            Application.OpenURL("http://losemyxelf.xyz/service.html");
        }
        [MenuItem("𝓐𝓾𝓽𝓲𝓼𝓶 𝓖𝓪𝓷𝓰/𝓤𝓽𝓲𝓵𝓲𝓽𝓲𝓮𝓼/𝓵𝔂𝔃𝓮 𝓓𝓲𝓼𝓬𝓸𝓻𝓭")]
        public static void ShowlyzeDiscord()
        {
            Application.OpenURL("https://discord.gg/NA7HqbqTF9");
        }
    }

}

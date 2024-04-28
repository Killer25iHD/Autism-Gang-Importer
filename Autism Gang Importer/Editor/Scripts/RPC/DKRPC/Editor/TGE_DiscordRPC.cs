using System;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

namespace TGE_SDK
{
    [InitializeOnLoad]
    public class TGE_DiscordRPC
    {
        private static readonly DiscordRpc.RichPresence presence = new DiscordRpc.RichPresence();

        private static TimeSpan time = (DateTime.UtcNow - new DateTime(1970, 1, 1));
        private static long timestamp = (long)time.TotalSeconds;

        private static RpcState rpcState = RpcState.EDITMODE;
        private static string GameName = Application.productName;
        private static string SceneName = SceneManager.GetActiveScene().name;

        static TGE_DiscordRPC()
        {
            if(!EditorPrefs.HasKey("TGE_discordRPC"))
            {
                EditorPrefs.SetBool("TGE_discordRPC", true);
            }

            if (EditorPrefs.GetBool("TGE_discordRPC"))
            {
                BRSLog("Starting discord rpc");
                DiscordRpc.EventHandlers eventHandlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize("1206987043318665236", ref eventHandlers, false, string.Empty);
                updateDRPC();
            }
        }

        public static void updateDRPC()
        {
            BRSLog("Updating everything");
            SceneName = SceneManager.GetActiveScene().name;
            presence.details = string.Format("♥ 𝒫𝓇𝑜𝒿𝑒𝒸𝓉 ♥: {0} ♥ 𝒮𝒸𝑒𝓃𝑒 ♥: {1}", GameName, SceneName);
            presence.state = "♥ 𝒮𝓉𝒶𝓉𝑒 ♥: " + rpcState.StateName();
            presence.startTimestamp = timestamp;
            presence.largeImageKey = "https://i.imgur.com/XH2Akf7.gif";
            presence.largeImageText = "♥ ◄ ♥ ► ♥";
            presence.smallImageText = "LoseMyXelf#7777";
            presence.smallImageKey = "killer_picpng_1";
            DiscordRpc.UpdatePresence(presence);
        }

        public static void updateState(RpcState state)
        {
            BRSLog("Updating state to '" + state.StateName() + "'");
            rpcState = state;
            presence.state = "♥ 𝒮𝓉𝒶𝓉𝑒 ♥: " + state.StateName();
            DiscordRpc.UpdatePresence(presence);
        }

        public static void sceneChanged(Scene newScene)
        {
            BRSLog("Updating scene name");
            SceneName = newScene.name;
            presence.details = string.Format("♥ 𝒫𝓇𝑜𝒿𝑒𝒸𝓉 ♥: {0} ♥ 𝒮𝒸𝑒𝓃𝑒 ♥: {1}", GameName, SceneName);
            DiscordRpc.UpdatePresence(presence);
        }

        public static void ResetTime()
        {
            BRSLog("Reseting timer");
            time = (DateTime.UtcNow - new DateTime(1970, 1, 1));
            timestamp = (long)time.TotalSeconds;
            presence.startTimestamp = timestamp;

            DiscordRpc.UpdatePresence(presence);
        }

        private static void BRSLog(string message)
        {
            Debug.Log("Killer's SDK DiscordRPC: " + message);
        }
    }
}
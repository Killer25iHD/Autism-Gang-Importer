using System;
using Discord;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteAlways]
public class DiscordController : MonoBehaviour
{
    private const long ClientId = 1206987043318665236;
    private static Discord.Discord _discord = null;
    private static TimeSpan time = (DateTime.UtcNow - new DateTime(1970, 1, 1));
    private static ActivityTimestamps timestamp = new ActivityTimestamps
    {
        Start = (long)time.TotalSeconds
    };
    private Scene scene;

    private void Start()
    {
        _discord = new Discord.Discord(ClientId, (ulong)CreateFlags.Default);
        scene = SceneManager.GetActiveScene(); // Fetch current scene
        UpdateDiscordActivity(scene);
    }

    private void Update()
    {
        if (_discord != null)
            _discord.RunCallbacks();
    }

    private void OnApplicationQuit()
    {
         Dispose();
    }

    private void UpdateDiscordActivity(Scene currentScene)
    {
        if (_discord == null)
            return;

        var activityManager = _discord.GetActivityManager();
        
        var activity = new Activity
        {
            State = "Scene: " + currentScene.name,
            Details = "Project: " + Application.productName,
            Assets =
            {
                LargeImage = "https://i.imgur.com/XH2Akf7.gif",
                LargeText = "♥ ◄ ♥ ► ♥",
                SmallImage = "killer_picpng_1",
                SmallText = "LoseMyXelf#7777"
            },
            Timestamps = timestamp,
        };
       
        

        activityManager.UpdateActivity(activity, result =>
        {
            if (result == Result.Ok)
            {
                Debug.Log("Discord Rich Presence updated successfully.");
            }
            else
            {
                Debug.Log("Discord Rich Presence failed to update.");
            }
        });
    }

    public static void Dispose()
    {
        if (_discord != null)
            _discord.Dispose();
    }
}
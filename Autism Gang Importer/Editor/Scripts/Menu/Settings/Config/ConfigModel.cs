namespace AutismImporter.Settings.Config
{
    public class ConfigModel
    {
        public DiscordModel DiscordSetting { get; set; } = new();
        public ImportablesModel Importables { get; set; } = new();
    }
}
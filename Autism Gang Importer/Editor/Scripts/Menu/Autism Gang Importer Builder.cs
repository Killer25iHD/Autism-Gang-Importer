namespace AutismImporter
{
    public interface AutismGangMenuBuilder
    {
        void ShowSettingsOptions();
        bool IsValidBuilder(out string message);
        void ShowBuilder();
        void RegisterBuilder(AutismGangMenu baseBuilder);
        void SelectAllComponents();
    }

}


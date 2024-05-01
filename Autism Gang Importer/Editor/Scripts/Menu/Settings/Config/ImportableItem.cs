using System;

namespace AutismImporter.Settings.Config
{
    public class ImportableItem
    {
        public string Name { get; set; }
        public Uri Uri { get; set; }
        public Categorys Category { get; set; }
    }
}
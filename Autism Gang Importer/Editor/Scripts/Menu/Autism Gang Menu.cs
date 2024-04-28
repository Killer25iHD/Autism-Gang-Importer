using UnityEditor;
using UnityEngine;

namespace AutismImporter
{
    [ExecuteInEditMode]
    public partial class AutismGangMenu : EditorWindow
    {
        public const int ImpWindowWidth = 518;
        public static AutismGangMenu window;

        public static GUIStyle titleGuiStyle;
        public static GUIStyle boxGuiStyle;
        public static GUIStyle infoGuiStyle;
        public static GUIStyle listButtonStyleEven;
        public static GUIStyle listButtonStyleOdd;
        public static GUIStyle listButtonStyleSelected;
        public static GUIStyle scrollViewSeparatorStyle;
        public static GUIStyle searchBarStyle;

        public int tabs = 3;
        

        private readonly string[] _tabOptions = { "Welcome", "Importer", "Credits" };

        private Texture _banner;

        private Texture2D image;


        private void OnGUI()
        {
            if (_banner == null)
                _banner = Resources.Load<Texture2D>("banner");


            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.BeginVertical();

            GUILayout.Box(_banner);
            //GUILayout.Box(image); //Or draw the texture


            EditorGUILayout.Space();

            tabs = GUILayout.Toolbar(tabs, _tabOptions);

            GUILayout.EndVertical();
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            tabs = 0;

            switch (tabs)
            {
                case 0:
                    ShowHello();
                    break;
                case 1:
                    ShowImport();
                    break;
                case 2:
                    ShowCredits();
                    break;
                default:
                    ShowHello();
                    break;
            }
        }

        [MenuItem("𝓐𝓾𝓽𝓲𝓼𝓶 𝓖𝓪𝓷𝓰/𝓘𝓶𝓹𝓸𝓻𝓽𝓮𝓻", false, 600)]
        private static void ShowImportPanel()
        {
            window = (AutismGangMenu)GetWindow(typeof(AutismGangMenu));
            window.titleContent.text = "Autism Gang Importer";
            window.minSize = new Vector2(ImpWindowWidth + 4, 600);
            window.maxSize = new Vector2(ImpWindowWidth + 4, 600);
            window.Init();
            window.Show();
        }

        private void InitializeStyles()
        {
            titleGuiStyle = new GUIStyle();
            titleGuiStyle.fontSize = 15;
            titleGuiStyle.fontStyle = FontStyle.BoldAndItalic;
            titleGuiStyle.alignment = TextAnchor.MiddleCenter;
            titleGuiStyle.wordWrap = true;
            if (EditorGUIUtility.isProSkin)
                titleGuiStyle.normal.textColor = Color.white;
            else
                titleGuiStyle.normal.textColor = Color.black;
            boxGuiStyle = new GUIStyle();
            if (EditorGUIUtility.isProSkin)
                boxGuiStyle.normal.textColor = Color.white;
            else
                boxGuiStyle.normal.textColor = Color.black;

            infoGuiStyle = new GUIStyle();
            infoGuiStyle.wordWrap = true;
            ;
            if (EditorGUIUtility.isProSkin)
                infoGuiStyle.normal.textColor = Color.white;
            else
                infoGuiStyle.normal.textColor = Color.black;
            infoGuiStyle.margin = new RectOffset(10, 10, 10, 10);

            listButtonStyleEven = new GUIStyle();
            listButtonStyleEven.margin = new RectOffset(0, 0, 0, 0);
            listButtonStyleEven.border = new RectOffset(0, 0, 0, 0);
            if (EditorGUIUtility.isProSkin)
                listButtonStyleEven.normal.textColor = new Color(0.8f, 0.8f, 0.8f);
            else
                listButtonStyleEven.normal.textColor = Color.black;

            listButtonStyleOdd = new GUIStyle();
            listButtonStyleOdd.margin = new RectOffset(0, 0, 0, 0);
            listButtonStyleOdd.border = new RectOffset(0, 0, 0, 0);
            if (EditorGUIUtility.isProSkin)
                listButtonStyleOdd.normal.textColor = new Color(0.8f, 0.8f, 0.8f);
            //listButtonStyleOdd.normal.background = CreateBackgroundColorImage(new Color(0.50f, 0.50f, 0.50f));
            else
                listButtonStyleOdd.normal.textColor = Color.black;

            listButtonStyleSelected = new GUIStyle();
            listButtonStyleSelected.normal.textColor = Color.white;
            listButtonStyleSelected.margin = new RectOffset(0, 0, 0, 0);
            if (EditorGUIUtility.isProSkin)
                listButtonStyleSelected.normal.textColor = new Color(0.8f, 0.8f, 0.8f);
            else
                listButtonStyleSelected.normal.textColor = Color.black;

            scrollViewSeparatorStyle = new GUIStyle("Toolbar");
            scrollViewSeparatorStyle.fixedWidth = ImpWindowWidth + 10;
            scrollViewSeparatorStyle.fixedHeight = 4;
            scrollViewSeparatorStyle.margin.top = 1;

            searchBarStyle = new GUIStyle("Toolbar");
            searchBarStyle.fixedWidth = ImpWindowWidth;
            searchBarStyle.fixedHeight = 23;
            searchBarStyle.padding.top = 3;
        }

        private void Init()
        {
            InitializeStyles();
        }
    }
}
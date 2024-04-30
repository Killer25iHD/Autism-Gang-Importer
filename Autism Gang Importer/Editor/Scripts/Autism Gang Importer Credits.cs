using UnityEditor;
using UnityEngine;

namespace AutismImporter
{
    public partial class AutismGangMenu : EditorWindow
    {
        private Texture _creditsImage;

        private void ShowCredits()
        {
            var a = new GUIStyle(EditorStyles.textField);
            a.normal.textColor = Color.white;
            var c = new GUIStyle(EditorStyles.miniButton);
            c.normal.textColor = Color.green;
            var b = new GUIStyle(EditorStyles.textField);
            b.normal.textColor = Color.magenta;

            SeperatorHelper.DrawSeparators(4);


            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.Space(20);
            GUI.backgroundColor = Color.black;
            GUILayout.BeginVertical("Thanks to", "window", GUILayout.Height(240), GUILayout.Width(340));


            {
                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("TT   ~ Thanks to all of you!");
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("PoH ~ Inspired me with his Old Import Panel");
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Kirari ~ For Helping with some Assets");
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Toxi ~ For Helping with some Designs");
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("notlyze ~ For Helping with the Downloadprocess");
                EditorGUILayout.EndHorizontal();

                SeperatorHelper.DrawSpace(15);


                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Made by: LoseMyXelf");
                EditorGUILayout.EndHorizontal();
            }


            GUILayout.EndVertical();
            GUILayout.Space(20);
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }
    }
}
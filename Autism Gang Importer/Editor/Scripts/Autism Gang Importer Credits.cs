
using UnityEngine;
using UnityEditor;

namespace AutismImporter
{

    public partial class AutismGangMenu : EditorWindow
    {
        private Texture _creditsImage;

        void ShowCredits()
        {
            GUIStyle a = new GUIStyle(EditorStyles.textField);
            a.normal.textColor = Color.white;
            GUIStyle c = new GUIStyle(EditorStyles.miniButton);
            c.normal.textColor = Color.green;
            GUIStyle b = new GUIStyle(EditorStyles.textField);
            b.normal.textColor = Color.magenta;




            EditorGUILayout.Separator();
            EditorGUILayout.Separator();
            EditorGUILayout.Separator();
            EditorGUILayout.Separator();


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

                EditorGUILayout.Space();
                EditorGUILayout.Space();
                EditorGUILayout.Space();
                EditorGUILayout.Space();
                EditorGUILayout.Space();
                EditorGUILayout.Space();
                EditorGUILayout.Space();
                EditorGUILayout.Space();
                EditorGUILayout.Space();
                EditorGUILayout.Space();
                EditorGUILayout.Space();
                EditorGUILayout.Space();
                EditorGUILayout.Space();
                EditorGUILayout.Space();
                EditorGUILayout.Space();


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

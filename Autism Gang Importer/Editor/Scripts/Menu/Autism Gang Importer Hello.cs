
using UnityEngine;
using UnityEditor;

namespace AutismImporter
{

    public partial class AutismGangMenu : EditorWindow
    {
        private Texture _HelloImage;

        void ShowHello()
        {
            GUIStyle a = new GUIStyle(EditorStyles.textField);
            a.normal.textColor = Color.black;
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
            GUI.backgroundColor = Color.red;
            GUILayout.BeginVertical("Welcome", "window", GUILayout.Height(240), GUILayout.Width(340));


            {

                GUILayout.Space(20);
                EditorGUILayout.BeginHorizontal();
                GUILayout.Label("Thank you for using the Autism Gang Importer!");
                EditorGUILayout.EndHorizontal();

                GUILayout.Space(20);
                EditorGUILayout.BeginHorizontal();
                GUILayout.Label("If you have any questions,\nplease be sure to ask the Admins or Mods of our Discord First!\nThank you for your Appreciation! ♥");
                EditorGUILayout.EndHorizontal();

                GUILayout.Space(20);
                EditorGUILayout.BeginHorizontal();
                GUILayout.Label("If you have any Feedback,\nplease be sure to reach out to the Admins or Mods of our Discord.♥");
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

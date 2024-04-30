using UnityEditor;

namespace AutismImporter
{
    public class SeperatorHelper
    {
        public static void DrawSeparators(int count)
        {
            for(int i = 0; i < count; i++)
            {
                EditorGUILayout.Separator();
            }
        }
        public static void DrawSpace(int count)
        {
            for(int i = 0; i < count; i++)
            {
                EditorGUILayout.Space();
            }
        }
        
    }
}
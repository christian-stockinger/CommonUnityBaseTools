using System.Text;
using UnityEditor;

namespace BaseTools.Utils.Scripts.InspectorHelper.HierarchySplitter
{
    [CustomEditor(typeof(HierarchySplitter))]
    public class HierarchySplitterEditor : Editor
    {
        private const int MAX_CHAR_LENGTH = 30;
        private const char SPACER_SYMBOL = '-';

        public override void OnInspectorGUI()
        {
            HierarchySplitter splitter = target as HierarchySplitter;
            SerializedProperty titleProperty = serializedObject.FindProperty("Title");
            EditorGUI.BeginChangeCheck();
            EditorGUILayout.PropertyField(titleProperty);
            if (EditorGUI.EndChangeCheck()) 
                UpdateSplitterText(splitter, titleProperty.stringValue);
            
            
            serializedObject.ApplyModifiedProperties();
        }

        private void UpdateSplitterText(HierarchySplitter splitter, string title)
        {
            splitter.name = GetFormattedTitle(title.Trim());
            EditorApplication.RepaintHierarchyWindow();
        }

        private string GetFormattedTitle(string title)
        {
            if (title.Length > MAX_CHAR_LENGTH)
                return Truncate(title,MAX_CHAR_LENGTH);
            
            int charLength = MAX_CHAR_LENGTH - title.Length;
            
            string left = new string(SPACER_SYMBOL, charLength / 2);
            string right = new string(SPACER_SYMBOL, charLength / 2);
            
            StringBuilder builder = new StringBuilder();
            builder.Append(left);
            builder.Append(" ");
            builder.Append(title.ToUpper());
            builder.Append(" ");
            builder.Append(right);

            return builder.ToString();
        }
        
        private string Truncate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
    }
}
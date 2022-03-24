using UnityEditor;
using UnityEngine;

namespace BaseTools.Utils.Scripts.InspectorHelper.HierarchySplitter
{
    /// <summary>
    /// Menu Item Functions for an better experience to the User
    /// </summary>
    public static class HierarchySplitterUtils
    {
        [MenuItem("GameObject/Create Header", false, 0)]
        private static void CreateHeader()
        {
            GameObject header = new GameObject();

            //Mark as EditorOnly, so it will not included in final build
            header.tag = "EditorOnly";
            header.AddComponent<HierarchySplitter>();

            //Hide the transform
            header.transform.hideFlags = HideFlags.NotEditable | HideFlags.HideInInspector;

            //Register undo
            Undo.RegisterCreatedObjectUndo(header, "Create Header");

            //Select the created header
            Selection.activeGameObject = header;
        }
    }
}
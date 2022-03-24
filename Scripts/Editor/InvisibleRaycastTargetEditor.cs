using UnityEditor;
using UnityEditor.UI;

[CanEditMultipleObjects, CustomEditor(typeof(InvisibleRaycastTarget), false)]
public class InvisibleRaycastTargetEditor : GraphicEditor
{
    public override void OnInspectorGUI ()
    {
        serializedObject.Update();
        RaycastControlsGUI();
        serializedObject.ApplyModifiedProperties();
    }
}
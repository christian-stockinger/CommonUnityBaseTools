using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// A concrete subclass of the Unity UI `Graphic` class that just skips drawing.
/// Useful for providing a raycast target without actually drawing anything.
/// </summary>

[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("UI/" + SCRIPT_NAME,-1)]
public class InvisibleRaycastTarget : Graphic
{
    private const string SCRIPT_NAME = "Invisible Raycast Target";

    public override void SetMaterialDirty() {
    }
    public override void SetVerticesDirty() {
    }

#if UNITY_EDITOR
    [MenuItem("GameObject/UI/" + SCRIPT_NAME)]
    private static void CreateInvisibileyRaycastObjectMenu(MenuCommand menuCommand)
    {
        // Create a custom game object
        GameObject go = new GameObject(SCRIPT_NAME);
        // Ensure it gets reparented if this was a context click (otherwise does nothing)
        GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
        // Register the creation in the undo system
        Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
        Selection.activeObject = go;
        go.AddComponent<RectTransform>();
        go.AddComponent<CanvasRenderer>();
        go.AddComponent<InvisibleRaycastTarget>();
        
    }
#endif
}

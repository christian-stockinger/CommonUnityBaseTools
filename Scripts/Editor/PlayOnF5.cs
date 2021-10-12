using UnityEditor;
using UnityEditor.SceneManagement;

namespace Packages.Editor
{
    /// <summary>
    /// This class is used to start the PlayMode with F5. As it is done in VisualStudio.
    /// </summary>
    public class PlayOnF5 : ScriptableObject
    {
        private const string PLAY_MENU_ITEM_PATH = "Edit/Play";

        [MenuItem("Edit/Run _F5")]
        private static void TogglePlayMode()
        {
            if (!Application.isPlaying)
            {
                EditorSceneManager.SaveScene(SceneManager.GetActiveScene());
            }
            EditorApplication.ExecuteMenuItem(PLAY_MENU_ITEM_PATH);
        }
    }
}
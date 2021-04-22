using System.Collections.Generic;
using CommonUnityBaseTools.Scripts.Helper.SerializableDictionary;
using UnityEngine.Events;
using UnityEngine;

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif


namespace CommonUnityBaseTools.Scripts.InspectorHelper.EventTranslators
{
    /// <summary>
    /// Separates event values to separated events.
    /// </summary>
#if ODIN_INSPECTOR
    public class IntEventTranslator : SerializedMonoBehaviour
#else
        public class IntEventTranslator : MonoBehaviour
#endif

    {
#if ODIN_INSPECTOR
        /// <summary>
        /// Dictionary with Actions separated by int Values
        /// </summary>
        public Dictionary<int, UnityEvent> Action;
#else
        public SerializableIntUnityEventDictionary Action;
#endif
        /// <summary>
        /// Checks if the given int is in the Actions and Execute it.
        /// </summary>
        /// <param name="value">int to Check</param>
        public void CheckInt(int value)
        {
            if(Action.ContainsKey(value))
                Action[value].Invoke();
        }

    }
}
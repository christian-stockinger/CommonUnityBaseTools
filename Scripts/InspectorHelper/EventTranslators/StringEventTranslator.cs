using System.Collections.Generic;
using CommonUnityBaseTools.Scripts.Helper.SerializableDictionary;
using UnityEngine;
using UnityEngine.Events;
#if ODIN_INSPECTOR
    using Sirenix.OdinInspector;
#endif


namespace CommonUnityBaseTools.Scripts.InspectorHelper.EventTranslators
{
    /// <summary>
    /// Separates default event values to separated events.
    /// </summary>
#if ODIN_INSPECTOR
        public class StringEventTranslator : SerializedMonoBehaviour
#else
        public class StringEventTranslator : MonoBehaviour
#endif
    {

#if ODIN_INSPECTOR
        /// <summary>
        /// Dictionary with Actions separated by int Values
        /// </summary>
        public Dictionary<string, UnityEvent> Action;
#else
        public SerializableStringUnityEventDictionary Action;
#endif

        /// <summary>
        /// Checks if the given string is in the Actions and Execute it.
        /// </summary>
        /// <param name="value">int to Check</param>
        public void CheckString(string value)
        {
            if (Action.ContainsKey(value))
                Action[value].Invoke();
        }
    }
}
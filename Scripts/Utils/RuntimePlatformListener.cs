using CommonUnityBaseTools.Scripts.Helper.SerializableDictionary;
using UnityEngine;
using UnityEngine.Events;

namespace BaseTools.Utils
{
    public class RuntimePlatformListener : MonoBehaviour
    {
        /// <summary>
        /// Event for Each Platform
        /// </summary>
        public SerializableRuntimePlatformUnityEventDictionary PlatformEvents;
        
        [Tooltip("Gets Fired if the Current Platform is not Selected int the BuildPlatformEvents")]
        public UnityEvent OtherPlatformEvent;
    
        void Awake()
        {
            if(PlatformEvents.ContainsKey(Application.platform))
                PlatformEvents[Application.platform].Invoke();
            else
                OtherPlatformEvent.Invoke();
        }
    }
}


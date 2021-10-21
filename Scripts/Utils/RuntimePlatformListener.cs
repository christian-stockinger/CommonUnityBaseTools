using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace BaseTools.Utils
{
    public class RuntimePlatformListener : SerializedMonoBehaviour
    {
        public Dictionary<RuntimePlatform, UnityEvent> PlatformEvents;
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


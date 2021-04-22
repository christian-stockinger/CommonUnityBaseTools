using System;
using UnityEngine.Events;

namespace CommonUnityBaseTools.Scripts.Helper.SerializableDictionary
{
    /// <summary>
    /// Serializable Dictionary<string, UnityEvent>
    /// </summary>
    [Serializable]
    public class SerializableStringUnityEventDictionary : SerializableDictionary<string, UnityEvent>
    {
    }
}

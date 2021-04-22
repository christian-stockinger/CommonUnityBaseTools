using System;
using UnityEngine.Events;

namespace CommonUnityBaseTools.Scripts.Helper.SerializableDictionary
{
    /// <summary>
    /// Serializable Dictionary<int,UnityEvent>
    /// </summary>
    [Serializable]
    public class SerializableIntUnityEventDictionary : SerializableDictionary<int,UnityEvent>
    {
    }
}

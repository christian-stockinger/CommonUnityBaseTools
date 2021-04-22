using System;
using UnityEngine;
using UnityEngine.Events;

namespace CommonUnityBaseTools.Scripts.InspectorHelper.UntiyEvents
{
    /// <summary>
    /// Unity Event for GameObjects
    /// </summary>
    [Serializable]
    public class GameObjectUnityEvent : UnityEvent<GameObject>
    {
    }
}
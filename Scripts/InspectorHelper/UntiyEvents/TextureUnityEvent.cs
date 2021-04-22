using System;
using UnityEngine;
using UnityEngine.Events;

namespace CommonUnityBaseTools.Scripts.InspectorHelper.UntiyEvents
{
    /// <summary>
    /// Unity Event for Textures
    /// </summary>
    [Serializable]
    public class TextureUnityEvent : UnityEvent<Texture>
    {
    }
}
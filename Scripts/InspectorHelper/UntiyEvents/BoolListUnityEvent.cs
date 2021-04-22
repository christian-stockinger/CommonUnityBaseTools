using System;
using System.Collections.Generic;
using UnityEngine.Events;

namespace CommonUnityBaseTools.Scripts.InspectorHelper.UntiyEvents
{
    /// <summary>
    /// Unity Event for Bool Lists
    /// </summary>
    [Serializable]
    public class BoolListUnityEvent : UnityEvent<List<bool>>
    {
    }
}

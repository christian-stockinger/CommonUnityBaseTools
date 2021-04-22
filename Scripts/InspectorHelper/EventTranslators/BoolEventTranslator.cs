using UnityEngine;
using UnityEngine.Events;

namespace CommonUnityBaseTools.Scripts.InspectorHelper.EventTranslators
{
    /// <summary>
    /// Inspector Events separate Bool Values
    /// </summary>
    public class BoolEventTranslator : MonoBehaviour
    {
        public UnityEvent OnTrue;
        public UnityEvent OnFalse;

        public void CheckBool(bool value)
        {
            if (value)
                OnTrue.Invoke();
            else
                OnFalse.Invoke();
        }
    }
}
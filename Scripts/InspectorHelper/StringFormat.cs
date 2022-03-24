using CommonUnityBaseTools.Scripts.InspectorHelper.UntiyEvents;
using UnityEngine;

namespace BaseTools.Utils
{
    /// <summary>
    /// Inspector Utility to convert Number from UnityEvents to an String Output
    /// </summary>
    [AddComponentMenu("Helper/" + nameof(StringFormat))]
    public class StringFormat : MonoBehaviour
    {
        public string Formatter;
        public StringUnityEvent FormatStringChanged;

        /// <summary>
        /// Formats the given Value with the Formatter string patter
        /// It will trigger an FormatStringChanged Event with the output.
        /// </summary>
        /// <param name="value">value with should be Formatted</param>
        private void FormatValue(object value)
        {
            TriggerFormatStringEvent(string.Format(Formatter, value));
        }

        /// <summary>
        /// Gets an Int from the Inspector Converts it by the Formatter string.
        /// It will trigger an FormatStringChanged Event with the output.
        /// </summary>
        /// <param name="value">Value with should be Formatted</param>
        public void FormatInt(int value)
        {
            FormatValue(value);
        }

        /// <summary>
        /// Gets an Float from the Inspector Converts it by the Formatter string.
        /// It will trigger an FormatStringChanged Event with the output.
        /// </summary>
        /// <param name="value">Value with should be Formatted</param>
        public void FormatFloat(float value)
        {
            FormatValue(value);
        }
        
        /// <summary>
        /// Gets an Double from the Inspector Converts it by the Formatter string.
        /// It will trigger an FormatStringChanged Event with the output.
        /// </summary>
        /// <param name="value">Value with should be Formatted</param>
        public void FormatDouble(double value)
        {
            FormatValue(value);
        }

        /// <summary>
        /// Triggers the FormatStringChanged event with the given string
        /// </summary>
        /// <param name="formatString">string with will be send to the Event</param>
        private void TriggerFormatStringEvent(string formatString)
        {
            UnityMainThreadDispatcher.Instance.Enqueue(() => FormatStringChanged?.Invoke(formatString));
        }
    }
}
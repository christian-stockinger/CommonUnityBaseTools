using System;
using System.Collections.Generic;
using UnityEngine;

namespace CommonUnityBaseTools.Scripts.Helper.SerializableDictionary
{
    /// <summary>
    /// Dictionary with Serialization Callback
    /// If used in the Inspector it needs to have an extra Class with an [Serializable] Attribute above
    /// </summary>
    /// <typeparam name="TKey">Key Type</typeparam>
    /// <typeparam name="TValue">Vale Type</typeparam>
    [Serializable]
    public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
    {
        /// <summary>
        /// List of Keys in the Dictionary
        /// </summary>
        [SerializeField] private List<TKey> keys = new List<TKey>();

        /// <summary>
        /// List of Values in the Dictionary
        /// </summary>
        [SerializeField] private List<TValue> values = new List<TValue>();

        /// <summary>
        /// save the dictionary to lists
        /// </summary>
        public void OnBeforeSerialize()
        {
            keys.Clear();
            values.Clear();
            foreach (KeyValuePair<TKey, TValue> pair in this)
            {
                keys.Add(pair.Key);
                values.Add(pair.Value);
            }
        }

        /// <summary>
        /// load dictionary from lists
        /// </summary>
        public void OnAfterDeserialize()
        {
            this.Clear();

            if (keys.Count != values.Count)
                throw new System.Exception(string.Format(
                    "there are {0} keys and {1} values after deserialization. Make sure that both key and value types are serializable."));

            for (int i = 0; i < keys.Count; i++)
                this.Add(keys[i], values[i]);
        }
    }
}
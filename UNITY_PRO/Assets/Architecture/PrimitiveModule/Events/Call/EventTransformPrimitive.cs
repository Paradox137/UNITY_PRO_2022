using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.Architecture.PrimitiveModule
{
    public class EventTransformPrimitive : MonoBehaviour
    {
        public event Action<Transform> OnEvent;
        
        [Button]
        public void Call(Transform value)
        {
            Debug.Log($"Event {name} was received with value {value}!");
            this.OnEvent?.Invoke(value);
        }
    }
}
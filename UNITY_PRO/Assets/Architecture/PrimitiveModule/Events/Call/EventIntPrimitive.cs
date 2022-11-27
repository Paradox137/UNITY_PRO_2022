using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.Architecture.PrimitiveModule
{
    public class EventIntPrimitive : MonoBehaviour
    {
        public event Action<int> OnEvent;
        
        [Button]
        public void Call(int value)
        {
            Debug.Log($"Event {name} was received with value {value}!");
            this.OnEvent?.Invoke(value);
        }
    }
}
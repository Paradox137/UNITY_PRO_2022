using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.Architecture.PrimitiveModule
{
    public class EventEmptyPrimitive : MonoBehaviour
    {   
        public event Action OnEvent;
        
        [Button]
        public void Call()
        {
            Debug.Log($"Event {name} was received!");
            this.OnEvent?.Invoke();
        }
    }
}
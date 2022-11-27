using System;
using Core.Architecture.PrimitiveModule.Enum;
using Core.Architecture.PrimitiveModule.Struct;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.Architecture.PrimitiveModule
{
    public class EventEnumPrimitive : MonoBehaviour
    {
        public event Action<EnumMoveDirectionPrimitive> OnEvent;

        [Button]
        public void Call(EnumMoveDirectionPrimitive value)
        {
            Debug.Log($"Event {name} was received with value {value}!");
            this.OnEvent?.Invoke(value);
        }
    }
}
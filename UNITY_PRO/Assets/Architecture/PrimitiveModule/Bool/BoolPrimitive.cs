using System;
using UnityEngine;

namespace Core.Architecture.PrimitiveModule.Bool
{
    public class BoolPrimitive : MonoBehaviour
    {
        public event Action<bool> OnValueChanged;
        
        [SerializeField] private bool value;

        public bool Value
        {
            get => value;
            set
            {
                this.value = value;
                this.OnValueChanged?.Invoke(this.value);
            }
        }
    }
}
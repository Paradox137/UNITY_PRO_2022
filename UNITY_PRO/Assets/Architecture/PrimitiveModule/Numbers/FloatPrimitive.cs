using System;
using UnityEngine;

namespace Core.Architecture.PrimitiveModule
{
    public class FloatPrimitive : MonoBehaviour
    {
        public event Action<float> OnValueChanged;

        public float Value
        {
            get { return this.value; }
            set
            {
                this.value = value;
                this.OnValueChanged?.Invoke(value);
            }
        }

        [SerializeField]
        private float value;
    }
}
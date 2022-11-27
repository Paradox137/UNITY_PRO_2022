using System;
using UnityEngine;

namespace Core.Architecture.PrimitiveModule
{
    public class IntPrimitive : MonoBehaviour
    {
        public event Action<int> OnValueChanged;

        public int Value
        {
            get { return this.value; }
            set
            {
                this.value = value;
                this.OnValueChanged?.Invoke(value);
            }
        }

        [SerializeField]
        private int value;
    }
}
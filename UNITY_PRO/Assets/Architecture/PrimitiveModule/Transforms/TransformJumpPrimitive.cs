using System;
using System.Collections;
using Core.Architecture.PrimitiveModule.Timers;
using DG.Tweening;
using UnityEngine;

namespace Core.Architecture.PrimitiveModule.Transforms
{
    public class TransformJumpPrimitive : MonoBehaviour
    {
        [SerializeField] private Transform Jumpable;
        public event Action OnEndJump;
        
        public void Jump(float power, float duration)
        {
            //Vector3 ReachVector = new Vector3(Jumpable.position.x, Jumpable.position.y + distance, Jumpable.position.z);
            Jumpable.DOJump(Jumpable.position, power, 1, duration).onComplete += OnComplete;
        }

        private void OnComplete()
        {
           OnEndJump?.Invoke();
           Debug.Log("Complete Jump");
        }
    }
}
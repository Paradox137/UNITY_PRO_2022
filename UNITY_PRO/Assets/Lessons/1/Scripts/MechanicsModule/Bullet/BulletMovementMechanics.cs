using System;
using Core.Architecture.PrimitiveModule;
using Core.Architecture.PrimitiveModule.Struct;
using Core.Architecture.PrimitiveModule.Timers;
using Core.Architecture.PrimitiveModule.Transforms;
using UnityEngine;

namespace Core.Lessons._1.Scripts.MechanicsModule.Bullet
{
    public class BulletMovementMechanics : MonoBehaviour
    {
        [SerializeField] private FloatPrimitive speed;

        [SerializeField] private TransformMovePrimitive moveTransform;

        [SerializeField] private FloatPrimitive distanceMax;
        
        private void FixedUpdate()
        {
            moveTransform.ChangePositionEveryFrame(Vector3.forward, speed.Value);

            if (moveTransform.Movable.position.z > distanceMax.Value)
            {
                Destroy(gameObject);
            }
        }
    }
}
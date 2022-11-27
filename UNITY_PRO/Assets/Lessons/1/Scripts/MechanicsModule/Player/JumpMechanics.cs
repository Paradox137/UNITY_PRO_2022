using System;
using Core.Architecture.PrimitiveModule;
using Core.Architecture.PrimitiveModule.Bool;
using Core.Architecture.PrimitiveModule.Timers;
using Core.Architecture.PrimitiveModule.Transforms;
using UnityEngine;
using UnityEngine.Rendering;

namespace Core.Lessons._1.Scripts.MechanicsModule.Player
{
    public class JumpMechanics : MonoBehaviour
    {
        [SerializeField] private FloatPrimitive force;
        [SerializeField] private FloatPrimitive duration;
        
        [SerializeField] private EventEmptyPrimitive jumpReceiver;

        [SerializeField] private TransformJumpPrimitive jumpTransform;

        [SerializeField] private BoolPrimitive permission;
        private void OnEnable()
        {
            jumpReceiver.OnEvent += Jump;
            jumpTransform.OnEndJump += SetPermission;
        }

        private void OnDisable()
        {
            jumpReceiver.OnEvent -= Jump;
            jumpTransform.OnEndJump -= SetPermission;
        }

        private void SetPermission()
        {
            permission.Value = true;
        }
        private void Jump()
        {
            if (permission.Value == true)
            {
                jumpTransform.Jump(force.Value, duration.Value);
                permission.Value = false;
            }
        }
    }
}
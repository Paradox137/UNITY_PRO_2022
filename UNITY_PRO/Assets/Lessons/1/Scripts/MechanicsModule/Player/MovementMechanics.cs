using System;
using Core.Architecture.PrimitiveModule;
using Core.Architecture.PrimitiveModule.Bool;
using Core.Architecture.PrimitiveModule.Enum;
using Core.Architecture.PrimitiveModule.Struct;
using Core.Architecture.PrimitiveModule.Transforms;
using Core.Architecture.SettingsModule.Player;
using UnityEngine;

namespace Core.Lessons._1.Scripts.MechanicsModule.Player
{
    public class MovementMechanics : MonoBehaviour
    {
        [SerializeField] private StructDirectionsPrimitive directions;
        
        [SerializeField] private IntPrimitive force;

        [SerializeField] private TransformMovePrimitive moveTransform;

        [SerializeField] private EventEnumPrimitive inputReceiver;
        
        
        private void OnEnable()
        {
           inputReceiver.OnEvent += Move;
        }

        private void OnDisable()
        {
           inputReceiver.OnEvent -= Move;
        }

        private void Move(EnumMoveDirectionPrimitive direction)
        {
            //? как по другмоу?
            switch (direction)
            {
                case EnumMoveDirectionPrimitive.forward:
                    moveTransform.ChangePosition(directions.forward, force.Value);
                    break;
                case EnumMoveDirectionPrimitive.back:
                    moveTransform.ChangePosition(directions.back, force.Value);
                    break;
                case EnumMoveDirectionPrimitive.left:
                    moveTransform.ChangePosition(directions.left, force.Value);
                    break;
                case EnumMoveDirectionPrimitive.right:
                    moveTransform.ChangePosition(directions.right, force.Value);
                    break;
            }
        }
    }
}
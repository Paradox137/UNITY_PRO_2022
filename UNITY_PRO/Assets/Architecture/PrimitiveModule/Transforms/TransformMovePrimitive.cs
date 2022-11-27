using UnityEngine;

namespace Core.Architecture.PrimitiveModule.Transforms
{
    public class TransformMovePrimitive : MonoBehaviour
    {
        [SerializeField] private Transform _movable;

        public Transform Movable => _movable;

        public void ChangePosition(Vector3 move, int force)
        {
            var newPos = new Vector3(move.x * force, move.y * force, move.z * force);
            
            Movable.position += move;
        }

        public void ChangePositionEveryFrame(Vector3 direction, float speed)
        {
            Movable.Translate(direction * speed);
        }
    }
}
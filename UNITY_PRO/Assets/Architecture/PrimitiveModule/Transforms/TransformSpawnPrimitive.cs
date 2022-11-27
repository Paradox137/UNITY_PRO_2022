using UnityEngine;

namespace Core.Architecture.PrimitiveModule.Transforms
{
    public class TransformSpawnPrimitive : MonoBehaviour
    {
        [SerializeField] private Transform _spawn;

        public Transform Spawn => _spawn;
    }
}
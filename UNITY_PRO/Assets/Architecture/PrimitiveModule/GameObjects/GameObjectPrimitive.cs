
using UnityEngine;

namespace Core.Architecture.PrimitiveModule.GameObjects
{
    public class GameObjectPrimitive : MonoBehaviour
    {
        [SerializeField] private GameObject _gameObjectObject;

        public void SpawnGameObject(Transform spawnPosition)
        {
            Object.Instantiate(_gameObjectObject, spawnPosition.position, Quaternion.identity);
        }
    }
}
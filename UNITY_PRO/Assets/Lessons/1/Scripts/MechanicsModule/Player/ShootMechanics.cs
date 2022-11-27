using System;
using Core.Architecture.PrimitiveModule;
using Core.Architecture.PrimitiveModule.GameObjects;
using Core.Architecture.PrimitiveModule.Transforms;
using Core.Lessons._1.Scripts.MechanicsModule.Bullet;
using UnityEngine;

namespace Core.Lessons._1.Scripts.MechanicsModule.Player
{
    public class ShootMechanics : MonoBehaviour
    {
        [SerializeField]
        private GameObjectPrimitive bullet;

        [SerializeField] private EventEmptyPrimitive shootReceiver;

        [SerializeField] private TransformSpawnPrimitive spawner;
        private void OnEnable()
        {
            shootReceiver.OnEvent += SpawnBullet;
        }

        private void OnDisable()
        {
            shootReceiver.OnEvent -= SpawnBullet;
        }
        private void SpawnBullet()
        {
            bullet.SpawnGameObject(spawner.Spawn);
        }
    }
}
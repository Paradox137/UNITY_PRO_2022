using Core.Architecture.PrimitiveModule;
using UnityEngine;

namespace Core.Lessons._1.Scripts.MechanicsModule.Player
{
    public class TakeDamageMechanics : MonoBehaviour
    {
        [SerializeField]
        private EventIntPrimitive takeDamageReceiver;

        [SerializeField]
        private IntPrimitive hitPoints;
        
        private void OnEnable()
        {
            this.takeDamageReceiver.OnEvent += this.OnDamageTaken;
        }

        private void OnDisable()
        {
            this.takeDamageReceiver.OnEvent -= this.OnDamageTaken;
        }

        private void OnDamageTaken(int damage)
        {
            this.hitPoints.Value -= damage;
        }
    }
}
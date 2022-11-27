using Core.Architecture.PrimitiveModule;
using UnityEngine;

namespace Core.Lessons._1.Scripts.MechanicsModule.Player
{
    public class DeathMechanics : MonoBehaviour
    {
        [SerializeField]
        private IntPrimitive hitPoints;

        [SerializeField]
        private EventEmptyPrimitive deathReceiver;

        private void OnEnable()
        {
            this.hitPoints.OnValueChanged += this.OnHitPointsChanged;
        }

        private void OnDisable()
        {
            this.hitPoints.OnValueChanged -= this.OnHitPointsChanged;
        }

        private void OnHitPointsChanged(int newHitPoints)
        {
            if (newHitPoints <= 0)
            {
                this.deathReceiver.Call();
            }
        }
    }
}
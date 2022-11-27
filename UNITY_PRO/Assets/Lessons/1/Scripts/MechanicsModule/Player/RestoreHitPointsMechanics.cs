using Core.Architecture.PrimitiveModule;
using Core.Architecture.PrimitiveModule.Timers;
using UnityEngine;
using UnityEngine.Serialization;

namespace Core.Lessons._1.Scripts.MechanicsModule.Player
{
    public class RestoreHitPointsMechanics : MonoBehaviour
    {
        //? Переименовать receiver в event, там где timer добавить timer?
        
        [SerializeField]
        private EventIntPrimitive takeDamageReceiver;

        [SerializeField]
        private IntPrimitive hitPoints;

        [FormerlySerializedAs("delay")] [SerializeField]
        private TimerPostCallPrimitive delayTime;

        [FormerlySerializedAs("restoreTimer")] [SerializeField]
        private TimerPeriodPrimitive restoreTime;

        private void OnEnable()
        {
            this.takeDamageReceiver.OnEvent += this.OnDamageTaken;
            this.delayTime.OnEnded += this.OnDelayEnded;
            this.restoreTime.OnEvent += this.OnRestoreHitPoints;

        }

        private void OnDisable()
        {
            this.takeDamageReceiver.OnEvent -= this.OnDamageTaken;
            this.delayTime.OnEnded -= this.OnDelayEnded;
            this.restoreTime.OnEvent -= this.OnRestoreHitPoints;
        }

        private void OnDamageTaken(int damage)
        {
            //Сброс задержки:
            this.delayTime.ResetTime();
            if (!this.delayTime.IsPlaying)
            {
                this.delayTime.Play();
            }
            
            this.restoreTime.Stop();
        }

        private void OnDelayEnded()
        {
            this.restoreTime.Play();
        }

        private void OnRestoreHitPoints()
        {
            this.hitPoints.Value+= 1;
            if (this.hitPoints.Value >= 10)
            {
                this.restoreTime.Stop();
            }
        }
    }
}
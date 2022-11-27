using System;
using System.Collections;
using Core.Architecture.PrimitiveModule;
using UnityEngine;

namespace Core.Architecture.PrimitiveModule.Timers
{
    public class TimerPeriodPrimitive : MonoBehaviour
    {
        public event Action OnEvent;
        
        public bool IsPlaying
        {
            get { return this.coroutine != null; }
        }

        private Coroutine coroutine;

        [SerializeField]
        private float period = 1.0f;

        public void Play()
        {
            if (this.coroutine == null)
            {
                this.coroutine = this.StartCoroutine(this.PeriodRoutine());
            }
        }

        public void Stop()
        {
            if (this.coroutine != null)
            {
                this.StopCoroutine(this.coroutine);
                this.coroutine = null;
            }
        }

        private IEnumerator PeriodRoutine()
        {
            var period = new WaitForSeconds(this.period);
            while (true)
            {
                yield return period;
                CallBacker.CallBack(this.GetType().Name,name, this.period);
                this.OnEvent?.Invoke();
            }
        }
    }
}
using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.Architecture.PrimitiveModule
{
    public static class CallBacker
    {
        //! Не получилось создать свой CallBack модуль в примитивах, больше MB - плохо и не надо, мб придумать какую-нибудь подписку?
        //! или и так окей и вызвать при дебаге этот модуль просто?
        public static void CallBack(string namePrimitive, string nameMechanic, float time)
        {
            Debug.Log($"Event <color=yellow>{namePrimitive}</color> of mechanic <color=green>{nameMechanic}</color> was ended after time <color=red>{time}</color>!");
        }
    }
}
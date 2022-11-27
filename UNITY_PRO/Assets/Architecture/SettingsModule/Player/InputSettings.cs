using UnityEngine;

namespace Core.Architecture.SettingsModule.Player
{
    public class InputSettings : MonoBehaviour
    {
        //TODO смотри телеграм 20.11:
        //? IN FUTURE all players settings?
        [SerializeField] private KeyCode left;
        [SerializeField] private KeyCode right;
        [SerializeField] private KeyCode back;
        [SerializeField] private KeyCode forward;
        [SerializeField] private float forceMovement;
        [SerializeField] private float forceJump;
    }
}
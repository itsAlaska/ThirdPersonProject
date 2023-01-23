using Combat;
using Combat.Targeting;
using UnityEngine;

namespace StateMachines.Player
{
    public class PlayerStateMachine : StateMachine
    {
        // Serialized field variables
        [field: SerializeField] public InputReader InputReader { get; private set; }
        [field: SerializeField] public CharacterController CharacterController { get; private set; }
        [field: SerializeField] public Animator Animator { get; private set; }
        [field: SerializeField] public Targeter Targeter { get; private set; }
        [field: SerializeField] public ForceReceiver ForceReceiver { get; private set; }
        [field: SerializeField] public Attack[] Attacks { get; private set; }
        [field: SerializeField] public WeaponDamage Weapon  { get; private set; }
        [field: SerializeField] public float FreeLookMovementSpeed { get; private set; }
        [field: SerializeField] public float TargetingMovementSpeed { get; private set; }
        [field: SerializeField] public float RotationDamping { get; private set; }
        
        
        // Public variables
        public Transform MainCameraTransform { get; private set; }

        // Unity built-in methods
        private void Start()
        {
            if (Camera.main != null) MainCameraTransform = Camera.main.transform;

            SwitchState(new PlayerFreeLookState(this));
        }
        
        // Private methods
        
    }
}
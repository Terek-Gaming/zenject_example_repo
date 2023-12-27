using UnityEngine;
using UnityEngine.InputSystem;
using ZenjectExample.Abstracts.Inputs;

namespace ZenjectExample.Inputs
{
    public class NewInputReader : IInputReader
    {
        readonly GameInputActions _inputs;

        public Vector2 Direction { get; private set; }
        public bool IsButtonDown => _inputs.Player.Fire.WasPressedThisFrame();

        public NewInputReader()
        {
            _inputs = new GameInputActions();

            _inputs.Player.Move.performed += HandleOnMove;
            _inputs.Player.Move.canceled += HandleOnMove;

            _inputs.Enable();
        }

        ~NewInputReader()
        {
            _inputs.Player.Move.performed -= HandleOnMove;
            _inputs.Player.Move.canceled -= HandleOnMove;

            _inputs.Disable();
        }

        void HandleOnMove(InputAction.CallbackContext context)
        {
            Direction = context.ReadValue<Vector2>();
        }
    }
}
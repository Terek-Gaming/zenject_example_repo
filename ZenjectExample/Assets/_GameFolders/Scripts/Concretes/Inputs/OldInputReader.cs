using UnityEngine;
using ZenjectExample.Abstracts.Inputs;

namespace ZenjectExample.Inputs
{
    public class OldInputReader : IInputReader
    {
        public Vector2 Direction
        {
            get
            {
                float horizontal = Input.GetAxis("Horizontal");
                float vertical = Input.GetAxis("Vertical");

                return new Vector2(horizontal, vertical);
            }
        }
        public bool IsButtonDown => Input.GetMouseButtonDown(0);
    }
}
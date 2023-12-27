using System;
using UnityEngine;
using ZenjectExample.Abstracts.Inputs;
using ZenjectExample.Abstracts.Movements;

namespace ZenjectExample.Controllers
{
    public class PlayerController_1 : MonoBehaviour
    {
        [Zenject.Inject] public IInputReader InputReader { get; private set; }
        [Zenject.Inject] public IMover Mover { get; private set; }

        void Start()
        {
            Mover.SetTranslate(this.transform);
        }

        void Update()
        {
            Vector2 direction = InputReader.Direction;
            Debug.Log(direction);
            Debug.Log(InputReader.IsButtonDown);
            
            Mover.Tick(direction);
        }

        void FixedUpdate()
        {
            Mover.FixedTick();
        }
    }
}


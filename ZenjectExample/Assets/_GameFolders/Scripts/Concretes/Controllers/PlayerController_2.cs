using UnityEngine;
using ZenjectExample.Abstracts.Inputs;
using ZenjectExample.Abstracts.Movements;
using ZenjectExample.Factories;

namespace ZenjectExample.Controllers
{
    public class PlayerController_2 : MonoBehaviour
    {
        IInputReader _inputReader;
        IMover _mover;

        [Zenject.Inject]
        public void Constructor(IInputReader inputReader, IMoveFactory moveFactory)
        {
            _inputReader = inputReader;
            _mover = moveFactory.Create(this.transform);
        }

        void Update()
        {
            Vector2 direction = _inputReader.Direction;
            Debug.Log(direction);
            Debug.Log(_inputReader.IsButtonDown);

            _mover.Tick(direction);
        }

        void FixedUpdate()
        {
            _mover.FixedTick();
        }
    }
}
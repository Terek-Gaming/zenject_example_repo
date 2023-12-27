using UnityEngine;
using ZenjectExample.Abstracts.Inputs;
using ZenjectExample.Abstracts.Movements;
using ZenjectExample.Factories;
using ZenjectExample.ScriptableObjects;

namespace ZenjectExample.Controllers
{
    public class PlayerController_3 : MonoBehaviour
    {
        IInputReader _inputReader;
        IMover _mover;
        IEntityStats _entityStats;

        [Zenject.Inject]
        public void Constructor(IInputReader inputReader, IMoveFactory moveFactory, [Zenject.Inject(Id = "Player")]IEntityStats stats)
        {
            _inputReader = inputReader;
            _mover = moveFactory.Create(this.transform);
            _entityStats = stats;
        }

        void Update()
        {
            Vector2 direction = _inputReader.Direction;

            _mover.Tick(direction * _entityStats.MoveSpeed);
        }

        void FixedUpdate()
        {
            _mover.FixedTick();
        }
    }
}
using UnityEngine;
using ZenjectExample.Abstracts.Controllers;
using ZenjectExample.Abstracts.Inputs;
using ZenjectExample.Abstracts.Movements;
using ZenjectExample.Factories;
using ZenjectExample.ScriptableObjects;

namespace ZenjectExample.Controllers
{
    public class PlayerController_4 : MonoBehaviour, IPlayerController
    {
        IInputReader _inputReader;
        IInputReaderFactory _inputFactory;

        IMover _mover;
        IEntityStats _entityStats;

        [Zenject.Inject]
        public void Constructor(IInputReaderFactory inputReaderFactory, IMoveFactory moveFactory,
            [Zenject.Inject(Id = "Player")] IEntityStats stats)
        {
            _inputFactory = inputReaderFactory;
            _inputReader = _inputFactory.Create();
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

        [ContextMenu(nameof(SwitchReference))]
        public void SwitchReference()
        {
            _inputReader = _inputFactory.Create();
            Debug.Log(_inputReader.GetType().ToString());
        }
    }
}
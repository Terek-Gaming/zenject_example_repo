using UnityEngine;
using ZenjectExample.Abstracts.Controllers;
using ZenjectExample.ScriptableObjects;

namespace ZenjectExample.Controllers
{
    public class FastEnemyController3 : AiEntityController
    {
        [Zenject.Inject(Id = "FastEnemy")] public IEntityStats Stats { get; private set; }
        [Zenject.Inject] public IPlayerController Target { get; private set; }

        protected override void Update()
        {
            if (Vector3.Distance(Target.transform.position, _transform.position) < 0.1f)
            {
                _mover.Tick(Vector2.zero);
                return;
            }

            var direction = Target.transform.position - _transform.position;
            _direction = new Vector2(direction.x, direction.y);
            _direction = _direction.normalized;
            _mover.Tick(_direction * Stats.MoveSpeed);
        }
    }
}
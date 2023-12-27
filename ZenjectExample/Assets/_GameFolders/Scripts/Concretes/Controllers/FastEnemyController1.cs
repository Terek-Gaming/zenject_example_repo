using UnityEngine;
using ZenjectExample.ScriptableObjects;

namespace ZenjectExample.Controllers
{
    public class FastEnemyController1 : AiEntityController
    {
        [Zenject.Inject(Id = "FastEnemy")] public IEntityStats Stats { get; private set; }

        protected override void Start()
        {
            _direction = new Vector2(Random.value, Random.value) - (Vector2)_transform.position;
            _direction = _direction.normalized;
        }

        protected override void Update()
        {
            _mover.Tick(_direction * Stats.MoveSpeed);
        }
    }
}
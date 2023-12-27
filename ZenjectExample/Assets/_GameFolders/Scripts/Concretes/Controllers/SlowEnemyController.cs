using ZenjectExample.ScriptableObjects;

namespace ZenjectExample.Controllers
{
    public class SlowEnemyController : AiEntityController
    {
        [Zenject.Inject(Id="SlowEnemy")]public IEntityStats Stats { get; private set; }

        protected override void Update()
        {
            MoveInputProcess(Stats.MoveSpeed);
        }
    }
}
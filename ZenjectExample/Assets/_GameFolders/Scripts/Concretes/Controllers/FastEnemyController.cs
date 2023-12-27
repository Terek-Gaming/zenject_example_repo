using ZenjectExample.ScriptableObjects;

namespace ZenjectExample.Controllers
{
    public class FastEnemyController : AiEntityController
    {
        [Zenject.Inject(Id="FastEnemy")]public IEntityStats Stats { get; private set; }

        protected override void Update()
        {
            MoveInputProcess(Stats.MoveSpeed);
        }
    }
}
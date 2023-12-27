using UnityEngine;
using Zenject;

namespace ZenjectExample.ScriptableObjects.Installer
{
    [CreateAssetMenu(fileName = "Stats Installer", menuName = "Installers/Stats Installer")]
    public class StatsSOInstaller : ScriptableObjectInstaller<StatsSOInstaller>
    {
        [SerializeField] EntityStatsSO _playerStats;
        [SerializeField] EntityStatsSO _slowEnemyStats;
        [SerializeField] EntityStatsSO _fastEnemyStats;
        [SerializeField] EnemySpawnerStatsSO _enemySpawnerStats;

        public override void InstallBindings()
        {
            // Container.BindInstance(_playerStats).WhenInjectedInto<PlayerController_3>();
            // Container.BindInstance(_slowEnemyStats).WhenInjectedInto<SlotEnemyController>();
            // Container.BindInstance(_fastEnemyStats).WhenInjectedInto<FastEnemyController>();
            Container.Bind<IEntityStats>().WithId("Player").To<EntityStatsSO>().FromInstance(_playerStats);
            Container.Bind<IEntityStats>().WithId("SlowEnemy").To<EntityStatsSO>().FromInstance(_slowEnemyStats);
            Container.Bind<IEntityStats>().WithId("FastEnemy").To<EntityStatsSO>().FromInstance(_fastEnemyStats);
            Container.Bind<IEnemySpawnerStats>().WithId("EnemySpawner").To<EnemySpawnerStatsSO>().FromInstance(_enemySpawnerStats);
        }
    }    
}

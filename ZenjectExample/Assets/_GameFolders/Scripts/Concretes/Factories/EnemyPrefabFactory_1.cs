using UnityEngine;
using Zenject;
using ZenjectExample.Controllers;
using ZenjectExample.ScriptableObjects;

namespace ZenjectExample.Factories
{
    public class EnemyPrefabFactory_1 : IFactory<AiEntityController>
    {
        readonly IEnemyPrefabHolder _enemyPrefabHolder;
        private readonly DiContainer _container;

        public EnemyPrefabFactory_1(DiContainer container, IEnemyPrefabHolder enemyPrefabHolder)
        {
            _container = container;
            _enemyPrefabHolder = enemyPrefabHolder;
        }
        
        public AiEntityController Create()
        {
            var enemyPrefab = _enemyPrefabHolder.GetRandomEntity();
            return _container.InstantiatePrefabForComponent<AiEntityController>(enemyPrefab);
        }
    }
}
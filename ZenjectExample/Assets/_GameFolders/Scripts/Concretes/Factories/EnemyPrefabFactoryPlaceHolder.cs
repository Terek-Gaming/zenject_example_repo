using UnityEngine;
using Zenject;
using ZenjectExample.Controllers;

namespace ZenjectExample.Factories
{
    public class EnemyPrefabFactoryPlaceHolder : PlaceholderFactory<AiEntityController>{}
    
    public class EnemyPrefabFactory1PlaceHolder : PlaceholderFactory<AiEntityController>{}

    public class EnemyPrefabFactory : IFactory<AiEntityController>
    {
        private readonly AiEntityController[] _prefabs;
        private readonly DiContainer _container;

        public EnemyPrefabFactory(DiContainer container, AiEntityController[] prefabs)
        {
            _container = container;
            _prefabs = prefabs;
        }
        
        public AiEntityController Create()
        {
            int index = Random.Range(0, _prefabs.Length);
            return _container.InstantiatePrefabForComponent<AiEntityController>(_prefabs[index]);
        }
    }
}
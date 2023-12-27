using UnityEngine;
using Zenject;
using ZenjectExample.Factories;
using ZenjectExample.ScriptableObjects;

namespace ZenjectExample.Controllers
{
    public class SpawnerController : MonoBehaviour
    {
        [Inject(Id = "EnemySpawner")] IEnemySpawnerStats _stats;
        [Inject] EnemyPrefabFactoryPlaceHolder _enemyPrefabFactory;

        float _currentTime = 0f;

        void Update()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > _stats.MaxTime)
            {
                _currentTime = 0f;
                var enemy = _enemyPrefabFactory.Create();
            }
        }
    }
}
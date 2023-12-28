using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using ZenjectExample.Factories;
using ZenjectExample.ScriptableObjects;

namespace ZenjectExample.Controllers
{
    public class SpawnerController_2 : MonoBehaviour
    {
        [Inject(Id = "EnemySpawner")] IEnemySpawnerStats _stats;
        [Inject] EnemyPrefabFactory1PlaceHolder _enemyPrefabFactory;

        [SerializeField] List<AiEntityController> _entities;
        
        float _currentTime = 0f;

        void Awake()
        {
            _entities = new List<AiEntityController>();
        }

        void Update()
        {
            if (_stats.MaxEnemyCount > _entities.Count) return;
            
            _currentTime += Time.deltaTime;
            if (_currentTime > _stats.MaxTime)
            {
                _currentTime = 0f;
                var enemy = _enemyPrefabFactory.Create();
                _entities.Add(enemy);
            }
        }
    }
}
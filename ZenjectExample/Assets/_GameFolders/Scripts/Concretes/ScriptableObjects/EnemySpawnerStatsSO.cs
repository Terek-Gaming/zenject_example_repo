using UnityEngine;

namespace ZenjectExample.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Enemy Spawner Stats", menuName = "Example Game/Stats/Enemy Spawner Stats")]
    public class EnemySpawnerStatsSO : ScriptableObject,IEnemySpawnerStats
    {
        [SerializeField] float _maxTime = 1f;
        [SerializeField] int _maxEnemyCount = 0;
        
        public float MaxTime => _maxTime;
        public int MaxEnemyCount => _maxEnemyCount;
    }

    public interface IEnemySpawnerStats
    {
        public float MaxTime { get; }
        public int MaxEnemyCount { get; }
    }
}
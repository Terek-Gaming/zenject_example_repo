using UnityEngine;

namespace ZenjectExample.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Enemy Spawner Stats", menuName = "Example Game/Stats/Enemy Spawner Stats")]
    public class EnemySpawnerStatsSO : ScriptableObject,IEnemySpawnerStats
    {
        [SerializeField] float _maxTime = 1f;
        
        public float MaxTime => _maxTime;
    }

    public interface IEnemySpawnerStats
    {
        public float MaxTime { get; }
    }
}
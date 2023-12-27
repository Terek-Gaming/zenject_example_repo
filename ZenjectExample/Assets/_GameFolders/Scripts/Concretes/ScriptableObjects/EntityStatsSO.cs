using UnityEngine;

namespace ZenjectExample.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Entity Stats", menuName = "Example Game/Stats/Entity Stats")]
    public class EntityStatsSO : ScriptableObject,IEntityStats
    {
        [SerializeField] float _moveSpeed = 5f;
        [SerializeField] int _maxDamage = 10;
        [SerializeField] int _maxHealth = 100;

        public float MoveSpeed => _moveSpeed;
        public int MaxHealth { get; }
        public int MaxDamage { get; }
    }

    public interface IEntityStats : IMoveStats,IHealthStats,IDamageStats
    {
        
    }

    public interface IMoveStats
    {
        float MoveSpeed { get; }
    }

    public interface IHealthStats
    {
        int MaxHealth { get; }
    }

    public interface IDamageStats
    {
        int MaxDamage { get; }
    }
}
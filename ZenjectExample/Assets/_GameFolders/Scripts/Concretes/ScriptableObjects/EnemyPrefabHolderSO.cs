using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenjectExample.Controllers;

namespace ZenjectExample.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Enemy Prefab Holder", menuName = "Example Game/Data Holder/Enemy Prefab Holder")]
    public class EnemyPrefabHolderSO : ScriptableObject, IEnemyPrefabHolder
    {
        [SerializeField] AiEntityController[] _prefabs;

        public AiEntityController[] Prefabs => _prefabs;

        public AiEntityController GetRandomEntity()
        {
            return _prefabs[Random.Range(0, _prefabs.Length)];
        }
    }

    public interface IEnemyPrefabHolder
    {
        AiEntityController[] Prefabs { get; }

        AiEntityController GetRandomEntity();
    }
}
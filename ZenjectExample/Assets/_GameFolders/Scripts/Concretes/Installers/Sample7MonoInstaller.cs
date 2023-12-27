using UnityEngine;
using Zenject;
using ZenjectExample.Controllers;
using ZenjectExample.Factories;

namespace ZenjectExample.Installers
{
    public class Sample7MonoInstaller : MonoInstaller
    {
        [SerializeField] AiEntityController _prefab;
        
        public override void InstallBindings()
        {
            Container.BindFactory<AiEntityController, EnemyPrefabFactory>().FromComponentInNewPrefab(_prefab);
            Container.Bind<IMoveFactory>().To<SimpleMoveFactory>().AsSingle().Lazy();
        }
    }
}
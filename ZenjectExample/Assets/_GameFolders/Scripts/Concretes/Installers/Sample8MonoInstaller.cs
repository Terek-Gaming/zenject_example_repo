using UnityEngine;
using Zenject;
using ZenjectExample.Controllers;
using ZenjectExample.Factories;

namespace ZenjectExample.Installers
{
    public class Sample8MonoInstaller : MonoInstaller
    {
        [SerializeField] AiEntityController[] _prefabs;
        
        public override void InstallBindings()
        {
            Container.BindInstance(_prefabs).WhenInjectedInto<EnemyPrefabFactory>();
            Container.BindFactory<AiEntityController, EnemyPrefabFactory1PlaceHolder>()
                .FromFactory<EnemyPrefabFactory>();
            
            Container.Bind<IMoveFactory>().To<SimpleMoveFactory>().AsSingle().Lazy();
        }
    }
}
using UnityEngine;
using Zenject;
using ZenjectExample.Abstracts.Controllers;
using ZenjectExample.Abstracts.Inputs;
using ZenjectExample.Controllers;
using ZenjectExample.Factories;
using ZenjectExample.Inputs;

namespace ZenjectExample.Installers
{
    public class Sample10MonoInstaller : MonoInstaller
    {
        [SerializeField] AiEntityController[] _prefabs;
        
        public override void InstallBindings()
        {
            Container.Bind<IInputReader>().To<NewInputReader>().AsSingle().NonLazy();
            Container.Bind<IPlayerController>().FromComponentInHierarchy().AsSingle().Lazy();
            Container.BindInstance(_prefabs).WhenInjectedInto<EnemyPrefabFactory>();
            Container.BindFactory<AiEntityController, EnemyPrefabFactory1PlaceHolder>()
                .FromFactory<EnemyPrefabFactory>();
            
            Container.Bind<IMoveFactory>().To<SimpleMoveFactory>().AsSingle().Lazy();
        }
    }
}
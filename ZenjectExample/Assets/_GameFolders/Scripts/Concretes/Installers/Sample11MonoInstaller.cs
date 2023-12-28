using UnityEngine;
using Zenject;
using ZenjectExample.Abstracts.Controllers;
using ZenjectExample.Abstracts.Inputs;
using ZenjectExample.Controllers;
using ZenjectExample.Factories;
using ZenjectExample.Inputs;
using ZenjectExample.ScriptableObjects;

namespace ZenjectExample.Installers
{
    public class Sample11MonoInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IInputReader>().To<NewInputReader>().AsSingle().NonLazy();
            Container.Bind<IPlayerController>().FromComponentInHierarchy().AsSingle().Lazy();
            // Container.Bind<IEnemyPrefabHolder>().To<EnemyPrefabHolderSO>().FromMethod(context => 
            //         LoadScriptableObjectFromResources<EnemyPrefabHolderSO>("EnemyPrefabHolder"))
            //     .AsSingle();
            Container.Bind<IEnemyPrefabHolder>().To<EnemyPrefabHolderSO>().FromResource("EnemyPrefabHolder").AsSingle();
            Container.BindFactory<AiEntityController, EnemyPrefabFactory1PlaceHolder>()
                .FromFactory<EnemyPrefabFactory_1>();
            
            Container.Bind<IMoveFactory>().To<SimpleMoveFactory>().AsSingle().Lazy();
        }
        
        private T LoadScriptableObjectFromResources<T>(string resourcePath) where T : ScriptableObject
        {
            //flexible can change with addressables
            return Resources.Load<T>(resourcePath);
        }
    }
}
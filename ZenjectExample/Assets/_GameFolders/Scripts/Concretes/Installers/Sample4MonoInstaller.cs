using Zenject;
using ZenjectExample.Abstracts.Inputs;
using ZenjectExample.Controllers;
using ZenjectExample.Factories;
using ZenjectExample.Inputs;

namespace ZenjectExample.Installers
{
    public class Sample4MonoInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IInputReader>().To<NewInputReader>().AsSingle().NonLazy();
            Container.Bind<IMoveFactory>().To<SimpleMoveFactory>().AsSingle().Lazy();
            Container.Bind<IMoveFactory>().To<SimpleMoveRigidBodyFactory>().AsSingle().WhenInjectedInto<PlayerController_2>().Lazy();
        }
    }
}
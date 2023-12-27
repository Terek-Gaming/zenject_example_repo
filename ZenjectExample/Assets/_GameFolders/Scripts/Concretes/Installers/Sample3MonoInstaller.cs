using Zenject;
using ZenjectExample.Abstracts.Inputs;
using ZenjectExample.Abstracts.Movements;
using ZenjectExample.Factories;
using ZenjectExample.Inputs;
using ZenjectExample.Movements;

namespace ZenjectExample.Installers
{
    public class Sample3MonoInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IInputReader>().To<NewInputReader>().AsSingle().NonLazy();
            Container.Bind<IMoveFactory>().To<SimpleMoveFactory>().AsSingle().Lazy();
        }
    }
}
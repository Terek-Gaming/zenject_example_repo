using Zenject;
using ZenjectExample.Abstracts.Inputs;
using ZenjectExample.Factories;
using ZenjectExample.Inputs;

namespace ZenjectExample.Installers
{
    public class Sample5MonoInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IInputReader>().To<NewInputReader>().AsSingle().NonLazy();
            Container.Bind<IMoveFactory>().To<SimpleMoveFactory>().AsSingle().Lazy();
        }
    }
}
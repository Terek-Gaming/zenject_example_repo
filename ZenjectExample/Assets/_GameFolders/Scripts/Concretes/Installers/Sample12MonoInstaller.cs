using Zenject;
using ZenjectExample.Factories;

namespace ZenjectExample.Installers
{
    public class Sample12MonoInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IInputReaderFactory>().To<InputReaderFactory>().AsSingle().NonLazy();
            Container.Bind<IMoveFactory>().To<SimpleMoveFactory>().AsSingle().Lazy();
        }
    }
}
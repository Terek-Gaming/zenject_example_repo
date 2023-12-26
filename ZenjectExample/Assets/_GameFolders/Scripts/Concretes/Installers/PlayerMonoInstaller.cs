using Zenject;
using ZenjectExample.Abstracts.Inputs;
using ZenjectExample.Abstracts.Movements;
using ZenjectExample.Inputs;
using ZenjectExample.Movements;

namespace ZenjectExample.Installers
{
    public class PlayerMonoInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IInputReader>().To<NewInputReader>().AsSingle().NonLazy();
            //Container.Bind<IInputReader>().To<OldInputReader>().AsSingle().NonLazy(); 
            Container.Bind<IMover>().To<MoveWithTranslate>().AsCached().Lazy();
            //Container.Bind<IMover>().To<MoveWithRigidBody>().AsCached().Lazy();
        }
    }    
}
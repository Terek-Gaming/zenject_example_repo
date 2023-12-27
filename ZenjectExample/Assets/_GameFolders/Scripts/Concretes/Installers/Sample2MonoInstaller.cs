using Zenject;
using ZenjectExample.Abstracts.Movements;
using ZenjectExample.Movements;

namespace ZenjectExample.Installers
{
    public class Sample2MonoInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            // Container.BindFactory<Transform, IMover, MoveWithTranslatePlaceHolderFactory>()
            //     .FromFactory<MoveWithTranslateFactory>();
            Container.Bind<IMover>().To<MoveWithTranslate>().AsTransient().Lazy();
        }
    }
}
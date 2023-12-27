using Zenject;
using ZenjectExample.Abstracts.Movements;
using ZenjectExample.Movements;

namespace ZenjectExample.Installers
{
    public class Sample2MonoInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IMover>().To<MoveWithTranslate>().AsTransient().Lazy();
        }
    }
}
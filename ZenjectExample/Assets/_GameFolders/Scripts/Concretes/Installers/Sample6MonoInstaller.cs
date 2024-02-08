using System.Collections.Generic;
using System.Threading.Tasks;
using Zenject;
using ZenjectExample.Abstracts.DataAccessLayers;
using ZenjectExample.Controllers;
using ZenjectExample.DataAccessLayers;
using ZenjectExample.Managers;
using ZenjectExample.Services;

namespace ZenjectExample.Installers
{
    public class Sample6MonoInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ISaveLoadService>().WithId(ConstNamesHelper.LOCAL).To<LocalSaveLoadManager>().AsSingle()
                .NonLazy();
            Container.Bind<ISaveLoadService>().WithId(ConstNamesHelper.CLOUD).To<CloudSaveLoadManager>().AsSingle()
                .NonLazy();

            Container.Bind<ISaveLoadDal>().To<LocalSaveLoadDal>().AsSingle().WhenInjectedInto<LocalSaveLoadManager>()
                .NonLazy();
            Container.Bind<ISaveLoadDal>().To<PlayFabSaveLoadDal>().AsSingle().WhenInjectedInto<CloudSaveLoadManager>()
                .NonLazy();
            // Container.Bind<ISaveLoadDal>().To<AzureSaveLoadDal>().AsSingle().WhenInjectedInto<CloudSaveLoadManager>()
            //     .NonLazy();
        }
    }

    public class AzureSaveLoadDal : ISaveLoadDal
    {
        public Task SaveDataAsync(string key, object value)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> LoadDataAsync<T>(string key)
        {
            throw new System.NotImplementedException();
        }
    }

    public class SaveLoadSystem
    {
        Dictionary<SaveLoadType, ISaveLoadService> _loadServices;

        public Dictionary<SaveLoadType, ISaveLoadService> SaveLoadServices => _loadServices;

        [Zenject.Inject]
        public SaveLoadSystem(ISaveLoadService localSaveLoadService, ISaveLoadService cloud1SaveLoadService,
            ISaveLoadService cloud2SaveLoadService)
        {
            _loadServices = new Dictionary<SaveLoadType, ISaveLoadService>()
            {
                { SaveLoadType.Local, localSaveLoadService },
                { SaveLoadType.PlayFab, cloud1SaveLoadService },
                { SaveLoadType.Azure, cloud2SaveLoadService }
            };
        }
    }

    public enum SaveLoadType : byte
    {
        Local,
        Azure,
        PlayFab,
        Firebase,
        GameSparks,
        HappyHourApi
    }
}
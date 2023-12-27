﻿using Zenject;
using ZenjectExample.Abstracts.DataAccessLayers;
using ZenjectExample.DataAccessLayers;
using ZenjectExample.Managers;
using ZenjectExample.Services;

namespace ZenjectExample.Installers
{
    public class Sample6MonoInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ISaveLoadService>().WithId("Local").To<LocalSaveLoadManager>().AsSingle().NonLazy();
            Container.Bind<ISaveLoadService>().WithId("Cloud").To<CloudSaveLoadManager>().AsSingle().NonLazy();

            Container.Bind<ISaveLoadDal>().To<LocalSaveLoadDal>().AsSingle().WhenInjectedInto<LocalSaveLoadManager>().NonLazy();
            Container.Bind<ISaveLoadDal>().To<PlayFabSaveLoadDal>().AsSingle().WhenInjectedInto<CloudSaveLoadManager>().NonLazy();
        }
    }
}
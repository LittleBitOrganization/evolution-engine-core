using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ServicesInstaller : MonoInstaller
{
    private ServicesLocator _servicesLocator;

    public override void InstallBindings()
    {
        InstallServicesLocator();
        InstallServices();
        RegisterServices();
    }

    private void InstallServicesLocator()
    {
        _servicesLocator = new ServicesLocator(Container);

        Container
            .Bind<ServicesLocator>()
            .FromInstance(_servicesLocator)
            .AsSingle()
            .NonLazy();
    }

    private void InstallServices()
    {
        InstallSaveService();
    }

    private void InstallSaveService()
    {
        Container
            .Bind<ISaveService>()
            .To<SaveService>()
            .AsSingle()
            .NonLazy();

        Container
            .Bind<ISaver>()
            .To<JsonSaver>()
            .AsSingle()
            .Lazy();
    }

    private void RegisterServices()
    {
        _servicesLocator.RegisterService<ISaveService>();
    }
}
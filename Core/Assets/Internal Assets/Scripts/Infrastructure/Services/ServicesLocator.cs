using System.ComponentModel.Design;
using UnityEngine;
using Zenject;

public class ServicesLocator
{
    private ServiceContainer _serviceContainer;
    private DiContainer diContainer;

    public ServicesLocator(DiContainer diContainer)
    {
        this.diContainer = diContainer;
        _serviceContainer = new ServiceContainer();
    }

    public void RegisterService<T>()
    {
        var service = diContainer.Resolve<T>();
        _serviceContainer.AddService(typeof(T), service);
        
        Debug.Log("Service (" + typeof(T).Name + ") successfully registered!");
    }

    public void UnregisterService<T>()
    {
        if (ServiceExists<T>()) _serviceContainer.RemoveService(typeof(T));
    }

    public T GetService<T>()
    {
        if (!ServiceExists<T>())
        {
            Debug.LogError("Trying get non existing service of type " + typeof(T).Name);
            return default(T);
        }

        return (T) _serviceContainer.GetService(typeof(T));
    }

    private bool ServiceExists<T>()
    {
        return _serviceContainer.GetService(typeof(T)) != null;
    }
}
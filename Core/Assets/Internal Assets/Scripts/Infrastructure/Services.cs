using System.ComponentModel.Design;
using UnityEngine;

public class Services
{
    private ServiceContainer _serviceContainer;

    public Services()
    {
        _serviceContainer = new ServiceContainer();
    }

    public void RegisterService<T>(IService service)
    {
        _serviceContainer.AddService(typeof(T), service);
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
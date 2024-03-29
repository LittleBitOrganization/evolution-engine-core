using System.Collections.Generic;
using UnityEngine;

namespace LittleBit.Context
{
    public interface  IDiContext
    {
        public abstract Transform ContextTransform { get; }
        public abstract void BindFromInstance<T>(T service);
        public abstract GameObject InstantiatePrefab(Object prefab, Vector3 position, Quaternion rotation, Transform parentTransform);
        public abstract void Bind<T>();
        public abstract void Unbind<T>();
        public abstract T Resolve<T>();
        public abstract IDiContext CreateContext();
        public abstract T Instantiate<T>(params object[] args);

        public abstract T InstantiateComponentOnNewGameObject<T>(string gameObjectName, IEnumerable<object> extraArgs) where T : Component;

        public ConcreteIdBinderFromNewComponentOnNewGameObject<T> BindInterfaceOnNewGameObject<T>();
        // {
        //     return new ConcreteIdBinderFromNewComponentOnNewGameObject<T>(this);
        // }

        public ConcreteIdBinder<T> BindInterface<T>();
        // {
        //     return new ConcreteIdBinder<T>(this);
        // }
    }
}

using System;
using UnityEngine;

namespace LittleBit.Context
{
    public class ConcreteIdBinderFromNewComponentOnNewGameObject<T>
    {
        private readonly IDiContext _diContext;
        public ConcreteIdBinderFromNewComponentOnNewGameObject(IDiContext diContext)
        {
            _diContext = diContext;
        }
        
        public void To<TFrom>() where TFrom : MonoBehaviour, T
        {
            string name = typeof(T).Name;
            var component =_diContext.InstantiateComponentOnNewGameObject<TFrom>(name, Array.Empty<object>());
            _diContext.BindFromInstance(component);
        }
        
    }
}
using System;

namespace LittleBit.Modules.CoreModule.MonoInterfaces
{
    public interface IDestroyable
    {
        public event Action<IDestroyable> Destroyed;
        public event Action OnStartDestroy;
        public void Destroy();
        public void SetDestroyType(DestroyType destroyType);
    }
}
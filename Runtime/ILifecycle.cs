using System;

namespace LittleBit.Modules.CoreModule
{
    public interface ILifecycle
    {
        public event Action<bool> onApplicationFocus;
        public event Action<bool> onApplicationPause;
        public event Action onApplicationQuit;
    }
}
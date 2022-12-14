using System;

namespace LittleBit.Modules.CoreModule.MonoInterfaces
{
    public interface IBootstraper
    {
        public void Run();
        public event Action OnComplete;
    }
}
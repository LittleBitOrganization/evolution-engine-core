using System;

namespace LittleBit.Modules.CoreModule
{
    public interface ITrackable
    {
        public double Value { get; }
        
        public event Action<double> OnValueChange;
    }
}
using System;

namespace LittleBit.Modules.CoreModule
{
    [Serializable]
    public class Resource : Data
    {
        public Resource(string id)
        {
            Id = id;
        }

        public double Value;

        public string Id;

        public Resource()
        {
            
        }
    }
}

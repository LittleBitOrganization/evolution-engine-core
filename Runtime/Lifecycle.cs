using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LittleBit.Modules.CoreModule
{
    public class Lifecycle : MonoBehaviour, ILifecycle
    {
        public event Action<bool> onApplicationFocus;
        public event Action<bool> onApplicationPause;
        public event Action onApplicationQuit;

        private void OnApplicationFocus(bool hasFocus)
        {
            onApplicationFocus?.Invoke(hasFocus);
        }

        private void OnApplicationPause(bool pauseStatus)
        {
            onApplicationPause?.Invoke(pauseStatus);
        }

        private void OnApplicationQuit()
        {
            onApplicationQuit?.Invoke();
        }
        
    }
}

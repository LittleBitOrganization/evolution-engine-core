using System.Collections;
using UnityEngine;

namespace LittleBit.Modules.CoreModule
{
    public interface ICoroutineRunner
    {
        public Coroutine StartCoroutine(IEnumerator coroutine);
    }
}


using UnityEngine;

namespace LittleBit.Modules.CoreModule.MonoInterfaces
{
    public interface ITransformable
    {
        public Transform GetTransform();
        public GameObject GetGameObject();
    }
}
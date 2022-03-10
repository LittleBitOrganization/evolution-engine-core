using System.Collections.Generic;

namespace LittleBit.Modules.CoreModule.MonoInterfaces
{
    public interface ILayout : ITransformable, IDestroyable, IActivatable
    {
        public void AppendChildElement(ILayout layout);
        public void RemoveElement(ILayout layout);
        public ILayout GetChildElementLayout(int index);
        public List<ILayout> GetAllChildrenElements();
        public void ShowChildElements();
        public void HideChildElements();
        public void SetParent(ILayout layout);
    }
}
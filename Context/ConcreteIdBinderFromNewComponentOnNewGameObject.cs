using UnityEngine;

namespace LittleBit.Context
{
    public class ConcreteIdBinderFromNewComponentOnNewGameObject<T>
    {
        private readonly Context _context;
        internal ConcreteIdBinderFromNewComponentOnNewGameObject(Context context)
        {
            _context = context;
        }
        
        public void To<TFrom>() where TFrom : MonoBehaviour, T
        {
            string name = typeof(T).Name;
            _context.BindFromInstance(InstantiateComponent<TFrom>(CreateGameObject(name)));
        }

        private GameObject CreateGameObject(string name)
        {
            var gameObj = new GameObject(name);
            var parent = _context.ContextTransform;
            if (parent == null)
            {
                gameObj.transform.SetParent(null, false);
            }
            else
            {
                gameObj.transform.SetParent(parent, false);
            }

            return gameObj;
        }

        private TFrom InstantiateComponent<TFrom>(GameObject gameObject) 
            where TFrom : MonoBehaviour, T
        {
            return gameObject.AddComponent<TFrom>();
        }
    }
}
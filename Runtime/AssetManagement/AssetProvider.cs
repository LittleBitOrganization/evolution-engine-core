
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace LittleBit.Modules.CoreModule.AssetManagement
{
    public class AssetProvider : IService
    {
        private Dictionary<Type, Dictionary<string, ArrayList>> _cashedAssets;

        public AssetProvider()
        {
            _cashedAssets = new Dictionary<Type, Dictionary<string, ArrayList>>();
        }

        public T GetAsset<T>(string path) where T : UnityEngine.Object
        {
            var type = typeof(T);

            T result = null;

            if (!_cashedAssets.ContainsKey(type))
                _cashedAssets.Add(type, new Dictionary<string, ArrayList>());

            if (!_cashedAssets[type].ContainsKey(path))
            {
                _cashedAssets[type].Add(path, new ArrayList());

                result = Resources.Load<T>(path);

                _cashedAssets[type][path].Add(result);

                return result;
            }

            result = (T) _cashedAssets[type][path][0];

            return result;
        }

        public T[] GetAssets<T>(string path) where T : UnityEngine.Object
        {
            T[] result = null;

            var type = typeof(T);

            if (!_cashedAssets.ContainsKey(type))

                _cashedAssets.Add(type, new Dictionary<string, ArrayList>());

            if (!_cashedAssets[type].ContainsKey(path))
            {
                _cashedAssets[type].Add(path, new ArrayList());
                
                result = Resources.LoadAll<T>(path);

                _cashedAssets[type][path].AddRange(result);

                return result;
            }

            result = _cashedAssets[type][path].Cast<T>().ToArray();

            return result;
        }
    }
}

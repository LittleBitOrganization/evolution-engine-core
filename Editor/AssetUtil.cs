using System.Text;
using UnityEditor;
using UnityEngine;

namespace LittleBit.Modules.CoreModule
{
    public static class AssetUtil
    {
        /// <summary>
        /// Create a folder in assets using AssetDatabase 
        /// </summary>
        /// <param name="fullPath">The full path of the folder, for example: Assets/Folder1/Folder2/Folder3/Folder4</param>
        public static void CreateFolders(string fullPath)
        {
            var pastBuilder = new StringBuilder();
            var leadBuilder = new StringBuilder();
            var folders = fullPath.Split('/');

            pastBuilder.Append(folders[0]);
            leadBuilder.Append(folders[0]);
            for (var index = 1; index < folders.Length; index++)
            {
                leadBuilder.Append("/");
                leadBuilder.Append(folders[index]);
                if (AssetDatabase.IsValidFolder(leadBuilder.ToString())) continue;
                AssetDatabase.CreateFolder(pastBuilder.ToString(), folders[index]);

                pastBuilder.Append("/").Append(folders[index]);
            }
        }
        
        /// <summary>
        /// Create scriptableObject in assets
        /// </summary>
        /// <param name="fullPath">The full path of the scriptableOjbect, for example: Assets/Folder1/scriptableName.asset</param>
        /// <typeparam name="T"></typeparam>
         public static void CreateScriptableInFolder<T>(string fullPath) where T : ScriptableObject
        {
            var pastBuilder = new StringBuilder();
            var leadBuilder = new StringBuilder();
            var folders = fullPath.Split('/');
            
            pastBuilder.Append(folders[0]);
            leadBuilder.Append(folders[0]);
            for (var index = 1; index < folders.Length; index++)
            {
                leadBuilder.Append("/");
                leadBuilder.Append(folders[index]);
                if (AssetDatabase.IsValidFolder(leadBuilder.ToString())) continue;
                AssetDatabase.CreateFolder(pastBuilder.ToString(), folders[index]);
                
                pastBuilder.Append("/").Append(folders[index]);
            }
            
            var instance = ScriptableObject.CreateInstance<T>();
            AssetDatabase.CreateAsset(instance, fullPath);
            AssetDatabase.SaveAssets();
        }
    }
}

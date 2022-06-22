using UnityEngine;

public interface ICreator
{
    public GameObject InstantiatePrefab(Object prefab);
    public GameObject InstantiatePrefab(Object prefab, Transform parentTransform);

    public GameObject InstantiatePrefab(Object prefab, Vector3 position, Quaternion rotation,
        Transform parentTransform);
    
    public T Instantiate<T>(params object[] args);
}

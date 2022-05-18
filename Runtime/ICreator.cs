using UnityEngine;

public interface ICreator
{
    public GameObject InstantiatePrefab(Object prefab);
    public T Instantiate<T>(params object[] args);
}

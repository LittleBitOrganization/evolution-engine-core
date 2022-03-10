using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICreator
{
    public GameObject InstantiatePrefab(UnityEngine.Object prefab);
}

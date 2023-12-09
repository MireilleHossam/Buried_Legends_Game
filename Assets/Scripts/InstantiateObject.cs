using System.Collections;

using UnityEngine;


public class InstantiateObject : MonoBehaviour
{
    // Reference to the prefab you want to instantiate
    public GameObject prefabToInstantiate;
    public GameObject spawnTransform;
    public bool useSpawnTransform;


    private void Update()
    {
      
    }
    public void SpawnObject()
    {
        if (useSpawnTransform)
        {
            Instantiate(prefabToInstantiate, spawnTransform.transform.position, spawnTransform.transform.rotation);
        }
        else
        {
            Instantiate(prefabToInstantiate, transform.position, Quaternion.identity);
        }
       
    }
}

using System.Collections;

using UnityEngine;


public class InstantiateObject : MonoBehaviour
{
    // Reference to the prefab you want to instantiate
    public GameObject prefabToInstantiate;



    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
            Debug.Log("pressed");
        }
    }
    public void SpawnObject()
    {
        Instantiate(prefabToInstantiate, transform.position, Quaternion.identity);
    }
}

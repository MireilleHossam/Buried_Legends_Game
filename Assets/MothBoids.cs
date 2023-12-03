using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MothBoids : MonoBehaviour
{

    public GameObject prefabToInstantiate;
    public int numberOfInstances = 5;

    void Start()
    {
        // Call a method to spawn the objects
        SpawnObjects();
    }

    void SpawnObjects()
    {
        // Check if the prefab is assigned
        if (prefabToInstantiate != null)
        {
            // Loop to instantiate objects
            for (int i = 0; i < numberOfInstances; i++)
            {
                // Instantiate the prefab at a random position
                Vector3 randomPosition = new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f));
                Instantiate(prefabToInstantiate, randomPosition, Quaternion.identity);
            }
        }
        else
        {
            Debug.LogError("Prefab not assigned in the inspector.");
        }
    }
}

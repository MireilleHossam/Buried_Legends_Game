using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MothBoids : MonoBehaviour
{

    public GameObject prefabToInstantiate;
    public int numberOfInstances = 5;

    public GameObject boundsObject;

    private Bounds bounds;

    void Start()
    {
        Renderer renderer = boundsObject.GetComponent<Renderer>();
        bounds = renderer.bounds;
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
                Vector3 randomPosition = SetRandomTargetPosition();
                Instantiate(prefabToInstantiate, randomPosition, Quaternion.identity);
            }
        }
        else
        {
            Debug.LogError("Prefab not assigned in the inspector.");
        }
    }

    Vector3 SetRandomTargetPosition()
    {
        // Generate a random target position within a specified range
        float randomX = Random.Range(bounds.center.x - bounds.extents.x, bounds.center.x + bounds.extents.x);
        float randomY = Random.Range(bounds.center.y - bounds.extents.y, bounds.center.y + bounds.extents.y);
        float randomZ = Random.Range(bounds.center.z - bounds.extents.z, bounds.center.z + bounds.extents.z);
        return new Vector3(randomX, randomY, randomZ);
    }
}

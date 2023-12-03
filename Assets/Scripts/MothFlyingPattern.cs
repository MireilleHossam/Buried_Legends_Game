using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MothFlyingPattern : MonoBehaviour
{
    public float moveSpeed = 5f;

    public GameObject boundsObject;

    private Bounds bounds;

    private Vector3 targetPosition;

    void Start()
    {
        // Set an initial target position
        SetRandomTargetPosition();

        Renderer renderer = boundsObject.GetComponent<Renderer>();
        bounds = renderer.bounds;
        //Debug.Log("Center: " + bounds.center);
        //Debug.Log("Size: " + bounds.size);
        //Debug.Log("Extents: " + bounds.extents);
        //Debug.Log($"X bounds are {bounds.center.x + bounds.extents.x} and {bounds.center.x - bounds.extents.x}");
    }


    void Update()
    {

        // Move towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);


        // Check if the target position is reached
        if (Vector3.Distance(transform.position, targetPosition) < 0.001f)
        {
           SetRandomTargetPosition();
        }
    }

    void SetRandomTargetPosition()
    {
        // Generate a random target position within a specified range
        float randomX = Random.Range(bounds.center.x - bounds.extents.x, bounds.center.x + bounds.extents.x);
        float randomY = Random.Range(bounds.center.y - bounds.extents.y, bounds.center.y + bounds.extents.y);
        float randomZ = Random.Range(bounds.center.z - bounds.extents.z, bounds.center.z + bounds.extents.z);
        targetPosition = new Vector3(randomX, randomY, randomZ);
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(targetPosition, .1f);
    }
}

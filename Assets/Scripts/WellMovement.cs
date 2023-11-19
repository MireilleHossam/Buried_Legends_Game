using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellMovement : MonoBehaviour
{
    public float moveSpeed = 0.3f; // Speed at which the well walls move
    // public float targetHeight = 2f;
    public float minHeight = 0.0f; // minimum height the well walls can move

    private bool moveFirst = false;


    void Update()
    {
        if (moveFirst == true)
        {
            MoveWell();
        }
    }

    public void MoveFirstFloor()
    {
        moveFirst = true;
    }

    public void MoveWell()
    {
        // Move the well walls downward
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime, Space.World);
        //added "space.world" because otherwise it moved to the side
        //turned gravity off as it made it fall too fast

        // add additional logic to stop the movement based on certain conditions
        // stop the movement when a specific height is reached->
        if (transform.position.y < minHeight)
        {
            moveFirst = false;
            moveSpeed = 0f;
        }
    }
}
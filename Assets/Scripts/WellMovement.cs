using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WellMovement : MonoBehaviour
{
    public float moveSpeed = 0.3f; // Speed at which the well walls move
    public float minHeight = 1.5f; // Minimum height the well walls can move
    public float maxHeight = -2.94f; // Maximum height
    public float midHeight = -1.5f; // Height for the second floor

    private int currentLevel = 0;

    void Update()
    {
        MoveWell();
    }

    private void MoveWell()
    {
        float targetHeight = currentLevel * midHeight;

        if (transform.position.y > targetHeight)
        {
            // Move the well walls upward in the world space
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime, Space.World);
        }
        else
        {
            // Stop the movement when the specific height is reached
            moveSpeed = 0f;
        }
    }

    public void MoveToNextFloor()
    {
        currentLevel++;

        // Reset the level when it reaches the maximum number of levels
        if (currentLevel >= 3)
        {
            currentLevel = 0;
        }

        // Reset moveSpeed to allow movement on the next button click
        moveSpeed = 0.3f;
    }
}
// public class WellMovement : MonoBehaviour
// {
//     public float moveSpeed = 0.3f; // Speed at which the well walls move
//     public float minHeight = 1.5f; // Minimum height the well walls can move
//     public float maxHeight = -2.94f; // Maximum height
//     public float midHeight = -1.5f; // Height for the second floor

//     private bool moveFirst = false;
//     private bool moveSecond = false;
//     private bool moveThird = false;

//     void Update()
//     {
//         if (moveFirst)
//         {
//             MoveOne();
//         }

//         if (moveSecond)
//         {
//             MoveTwo();
//         }

//         if (moveThird)
//         {
//             MoveThree();
//         }
//     }

//     public void MoveFirstFloor()
//     {
//         moveFirst = true;
//         moveSecond = false;
//         moveThird = false;
//     }

//     public void MoveSecondFloor()
//     {
//         moveFirst = false;
//         moveSecond = true;
//         moveThird = false;
//     }

//     public void MoveThirdFloor()
//     {
//         moveFirst = false;
//         moveSecond = false;
//         moveThird = true;
//     }

//     private void MoveOne()
//     {
//         // Move the well walls downward
//         transform.Translate(Vector3.down * moveSpeed * Time.deltaTime, Space.World);

//         // Stop the movement when a specific height is reached
//         if (transform.position.y < minHeight)
//         {
//             moveFirst = false;
//             moveSpeed = 0f;
//         }
//     }

//     private void MoveTwo()
//     {
//         transform.Translate(Vector3.down * moveSpeed * Time.deltaTime, Space.World);

//         if (transform.position.y < midHeight)
//         {
//             moveSecond = false;
//             moveSpeed = 0f;
//         }
//     }

//     private void MoveThree()
//     {
//         transform.Translate(Vector3.down * moveSpeed * Time.deltaTime, Space.World);

//         if (transform.position.y < maxHeight)
//         {
//             moveThird = false;
//             moveSpeed = 0f;
//         }
//     }
// }

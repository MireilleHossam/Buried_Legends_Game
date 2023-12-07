using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabSwordFloorMoves : MonoBehaviour
{
    private WellMovement wellMovement;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand")) // Adjust the tag based on your player's hand tag
        {
            GrabSword();
        }
    }

    private void GrabSword()
    {
        // Instantiate sword prefab and other actions
        // ...

        // Call the MoveWell function when the sword is grabbed
        if (wellMovement != null)
        {
            wellMovement.MoveSecondFloor();
        }
    }


}

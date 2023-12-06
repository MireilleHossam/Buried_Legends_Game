using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabSwordFloorMoves : MonoBehaviour
{
    private WellMovement wellMovement;



   // void Start()
    //{
       // Debug.Log("hold sword");
       // wellMovement.MoveSecondFloor();

//    }
    private bool isGrabbed = false;

    void Start()
    {
        StartCoroutine(CheckForGrab());
    }

    IEnumerator CheckForGrab()
    {
        // Wait for a short delay after instantiation
        yield return new WaitForSeconds(0.5f);

        // Check if the object is grabbed using XR Grab Interactable
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();

        while (!isGrabbed)
        {
            if (grabInteractable != null && grabInteractable.isSelected)
            {
                // The object is grabbed
                isGrabbed = true;
                Debug.Log("Object is grabbed!");
                wellMovement.MoveSecondFloor(); break;
            }

            // Check again in the next frame
            yield return null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabSwordFloorMoves : MonoBehaviour
{
    private WellMovement wellMovement;



    private XRGrabInteractable interactable;

    private void Start()
    {
        // Get the XRGrabInteractable component on the object
        interactable = GetComponent<XRGrabInteractable>();

        if (interactable == null)
        {
            Debug.LogError("XRGrabInteractable component not found on the object.");
        }
        else
        {
            // Subscribe to the OnSelectEntered event to detect when the object is grabbed
            interactable.onSelectEntered.AddListener(OnGrabbed);
        }
    }

    private void OnGrabbed(XRBaseInteractor interactor)
    {
        // The function to call when the object is grabbed
        Debug.Log("Object is grabbed! Calling your function...");

        // Call your custom function here
        //MoveSecondFloor();
    }

    
}


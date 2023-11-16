using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabTrigger : MonoBehaviour
{
    public XRGrabInteractable heldObject; // Reference to the object that can be held  Mariams Objects
    public Transform wellMove; // the well moves

    private bool isHeld = false; // make the well stationary
   
    void Start()
    {
        // Attach event listeners
        heldObject.onSelectEntered.AddListener(OnObjectGrab);
        
    }

    void Update()
    {

        
        if (isHeld)
        {
            // ADD a delay of 20 seconds
            // AMIRAS Code
        }
    }

    void OnObjectGrab(XRBaseInteractor interactor)
    {
        isHeld = true;
    }

   

}



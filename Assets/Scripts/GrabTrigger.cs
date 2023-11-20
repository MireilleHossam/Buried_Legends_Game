using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabTrigger : MonoBehaviour
{
    public XRGrabInteractable heldObject; // Reference to the object that can be held  Mariams Objects
    public Transform wellMove; // the well moves

    public float movementDelay= 20;
   
    void Start()
    {
        // Attach event listeners
        heldObject.onSelectEntered.AddListener(OnObjectGrab);
        
    }

    void Update()
    {

    }

    void OnObjectGrab(XRBaseInteractor interactor)
    {
        Invoke("function of amii", movementDelay);
    }

   

}



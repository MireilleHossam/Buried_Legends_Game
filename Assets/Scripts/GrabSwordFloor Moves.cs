using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabSwordFloorMoves : MonoBehaviour
{
    private WellMovement wellMovement;
    private XRGrabInteractable interactable;
    public GameObject disabledObject;
    public GameObject disabledObject2;


    private void Awake()
    {
        interactable = GetComponent<XRGrabInteractable>();
        interactable.selectEntered.AddListener(OnSelectEntered);

    }

    private void OnSelectEntered(SelectEnterEventArgs arg0)
    {
        MoveFloor();
        AwakeDisabledObject();
        
    }

    public void MoveFloor()
    {
        EventsManager.MoveSecondFloor();
        Debug.Log("Grabbed sword");
    }

    private void AwakeDisabledObject()
    {
        if (disabledObject != null && disabledObject2 != null)
        {
            // Set the object active
            disabledObject.SetActive(true);
            disabledObject2.SetActive(true);
        }
        else
        {
            Debug.LogError("Disabled object reference is null. Please assign a valid object in the inspector.");
        }
    }

}

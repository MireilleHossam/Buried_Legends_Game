using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabSwordFloorMoves : MonoBehaviour
{
    private WellMovement wellMovement;
    private XRGrabInteractable interactable;

    private void Awake()
    {
        interactable = GetComponent<XRGrabInteractable>();
        interactable.selectEntered.AddListener(OnSelectEntered);

    }

    private void OnSelectEntered(SelectEnterEventArgs arg0)
    {
        MoveFloor();
    }

    public void MoveFloor()
    {
        EventsManager.MoveSecondFloor();
        Debug.Log("Grabbed sword");
    }



}

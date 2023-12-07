using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabSwordFloorMoves : MonoBehaviour
{
    private WellMovement wellMovement;
    

    public void MoveFloor()
    {
        EventsManager.MoveSecondFloor();
        Debug.Log("Grabbed sword");
    }


}

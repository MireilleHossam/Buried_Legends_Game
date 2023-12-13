using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonwithPlayer : MonoBehaviour
{
    private WellMovement wellMovement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sword"))
        {
            Debug.Log("collision made");
            MoveThirdFloor();
        }
    }
    public void MoveThirdFloor()
    {
        EventsManager.MoveSecondFloor();
        Debug.Log("COLLISION sword");
    }
}
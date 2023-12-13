using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonwithPlayer : MonoBehaviour
{
    private WellMovement wellMovement;
    //ivate InstantiateObject instantiateObject;

    private void Start()
    {
        // Assuming the InstantiateObject script is on the same GameObject
        //stantiateObject = GetComponent<InstantiateObject>();

        // If the InstantiateObject script is on a different GameObject, you might need to find it using other methods.
        // instantiateObject = GameObject.FindObjectOfType<InstantiateObject>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sword"))
        {
            Debug.Log("collision made");
            wellMovement.MoveThirdFloor();

        }
    }
   //ublic void MoveThirdFloor()
   //
    //  EventsManager.MoveSecondFloor();
    //  Debug.Log("COLLISION sword");
    //

}
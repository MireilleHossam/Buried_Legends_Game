using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabSwordFloorMoves : MonoBehaviour
{
    private WellMovement wellMovement;

    // You need to assign a prefab to this field in the Unity Editor.
    public GameObject prefab;

    void Start()
    {
        // Instantiate the prefab in the Start method.
        GameObject prefabInstance = GameObject.Instantiate(prefab) as GameObject;

        if (prefabInstance != null)
        {
            // Assuming MyScript is the correct script name. Replace it with the actual script name.
            var myScriptReference = prefabInstance.GetComponent<WellMovement>();

            if (myScriptReference != null)
            {
                myScriptReference.MoveSecondFloor();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAppear : MonoBehaviour
{
    public float appearanceTime = 2f;

    private void Start()
    {
        // Make the object initially not invisible
        SetObjectVisibility(false);

        // Invoke the method to make the object appear after a specified time
        Invoke("MakeObjectAppear", appearanceTime);
    }

    private void MakeObjectAppear()
    {
        // Make the object visible
        SetObjectVisibility(true);
    }

    private void SetObjectVisibility(bool isVisible)
    {
        // Set the object's renderer or active state based on visibility
        // You need to replace "YourObjectName" with the actual name of your object
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.enabled = isVisible;
        }
        else
        {
            gameObject.SetActive(isVisible);
        }
    }
}


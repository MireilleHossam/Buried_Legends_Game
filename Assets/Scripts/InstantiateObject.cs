using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InstantiateObject : MonoBehaviour
{
    // Reference to the prefab you want to instantiate
    public GameObject prefabToInstantiate;

    private XRGrabInteractable grabInteractable;

    void Start()
    {
        Instantiate(prefabToInstantiate, transform.position, transform.rotation);
    }

}

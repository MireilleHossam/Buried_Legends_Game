using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordInstatiation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<InstantiateObject>().SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

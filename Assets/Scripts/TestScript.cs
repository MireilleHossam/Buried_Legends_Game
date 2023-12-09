using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject characterInstantiator;
    // Start is called before the first frame update

    private void Awake()
    {
        
    }
    void Start()
    {

        characterInstantiator.GetComponent<InstantiateObject>().SpawnObject();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            characterInstantiator.GetComponent<InstantiateObject>().SpawnObject();
        }
    }

    public void Interact()
    {
        Debug.Log("movement");
    }
}

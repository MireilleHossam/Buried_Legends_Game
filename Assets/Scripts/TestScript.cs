using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public Transform movementObject;
    private WellMovement wellMover;
    // Start is called before the first frame update

    private void Awake()
    {
        wellMover = movementObject.GetComponent<WellMovement>();
    }
    void Start()
    {
        Debug.Log(wellMover.ToString());
        wellMover.MoveFirstFloor();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        Debug.Log("movement");
    }
}

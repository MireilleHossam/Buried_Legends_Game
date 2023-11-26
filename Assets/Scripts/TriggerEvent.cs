using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("YourTag"))
        {
            // Assuming EventHandlerScript is attached to another GameObject in the scene
            EventHandlerScript eventHandler = FindObjectOfType<EventHandlerScript>();

            if (eventHandler != null)
            {
                // Call the method in EventHandlerScript
                eventHandler.HandleCollision();
            }
        }
    }
}

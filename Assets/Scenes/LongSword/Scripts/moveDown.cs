using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveDown : MonoBehaviour
{
public Transform objectMove;
public float moveSpeed = 0.3f;

private void Start()
    {
     // Attach the button click event to the method
    Button button = GetComponent<Button>();
    button.onClick.AddListener(MoveObjectDownOnClick);
    }

private void MoveObjectDownOnClick()
    {
        // Move the object down when the button is clicked
        if (objectMove != null)
        {
            objectMove.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
    }
}

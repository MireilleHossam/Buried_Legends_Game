
using System;
using UnityEngine;
using UnityEngine.Events;

public class TorchesTracker : MonoBehaviour
{
    [Tooltip("The initial candle flame Object")]
    [SerializeField]
    private Flammable startingObject;
    [Tooltip("All the torches need to be lit to move the floor")]
    [SerializeField]
    private Flammable[] TorchesToMoveFloor;
    [Tooltip("Well movement control object")]
    [SerializeField]
    private WellMovement wellMovement;


    // Start is called before the first frame update
    void Start()
    {
        startingObject.SetOnFire();    
    }

    private void OnEnable()
    {
        EventsManager.OnTorchIgnited += CheckTorchesFlammability;
    }

    private void OnDisable()
    {
        EventsManager.OnTorchIgnited -= CheckTorchesFlammability;
    }

    public void CheckTorchesFlammability()
    {
        if (TorchesToMoveFloor == null) { return; }
        foreach (Flammable torch in TorchesToMoveFloor)
        {
            if (torch.IsOnFire() is false)
            {
                return;
            }
        }
        wellMovement.MoveFirstFloor();
    }
    private void ShuffleArray<T>(T[] array)
    {
        int n = array.Length;
        for (int i = n - 1; i > 0; i--)
        {
            int randIndex = UnityEngine.Random.Range(0, i + 1);
            T temp = array[i];
            array[i] = array[randIndex];
            array[randIndex] = temp;
        }
    }
}

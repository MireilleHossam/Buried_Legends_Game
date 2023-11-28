using UnityEngine;

public class Flammable : MonoBehaviour
{
    private bool isOnFire = false;
    [SerializeField]
    private GameObject flameVisuals;
    


    private void OnEnable()
    {
        
    }
    public void SetOnFire()
    {
        flameVisuals.SetActive(true);
        isOnFire = true;
        EventsManager.TrackLitTorches();
    }

    public bool IsOnFire()
    {
        return isOnFire;
    }
}
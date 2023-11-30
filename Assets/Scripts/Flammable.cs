using UnityEngine;

public class Flammable : MonoBehaviour
{
    private bool isOnFire = false;
    [SerializeField]
    private GameObject flameVisuals;

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
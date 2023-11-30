using UnityEngine;

public class Igniter : MonoBehaviour
{
    Flammable _flammable;

    private void Start()
    {
        _flammable = GetComponent<Flammable>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (_flammable.IsOnFire() is false) { return; }

        var flammable = other.GetComponent<Flammable>();
        if (flammable is not null)
        {
            flammable.SetOnFire();
        }
    }
}

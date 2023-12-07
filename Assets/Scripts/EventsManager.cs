using System;

public static class EventsManager
{
    public static Action OnTorchIgnited;
    public static Action OnSwordPickedUp;

    public static void TrackLitTorches()
    {
        OnTorchIgnited?.Invoke();
    }

    public static void MoveSecondFloor()
    {
        OnSwordPickedUp?.Invoke();
    }
}
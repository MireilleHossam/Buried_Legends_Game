using System;

public static class EventsManager
{
    public static Action OnTorchIgnited;

    public static void TrackLitTorches()
    {
        OnTorchIgnited?.Invoke();
    }
}
using UnityEngine;
using UnityEngine.Events;
[AddComponentMenu("Duc Anh/GameEvent")]

public static class GameEvent
{
    public static UnityEvent eventUpdateUI;
    public static UnityEvent<int> eventScore;
    public static UnityEvent<int> eventScoreComplete;

}

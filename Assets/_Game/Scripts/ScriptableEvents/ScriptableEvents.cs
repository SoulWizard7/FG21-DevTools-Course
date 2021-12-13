using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new scriptable event", menuName = "ScriptableObj/ScriptableEvents/newEvent")]
public class ScriptableEvents : ScriptableObject
{
    private event Action _event;

    public void Register(Action onEvent)
    {
        _event += onEvent;
    }

    public void Unregister(Action onEvent)
    {
        _event -= onEvent;
    }

    public void Raise()
    {
        _event?.Invoke(); //if event is not null = ?
    }

}

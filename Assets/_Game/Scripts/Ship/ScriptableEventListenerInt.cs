using System;
using ScriptableEvents;
using UnityEngine;
using UnityEngine.Events;

public class ScriptableEventListenerInt : ScriptableEventListener<int, ScriptableEventInt, UnityEvent<int>>
{
    
}

[Serializable]
public class UnityEventInt : UnityEvent<int>
{
    
}
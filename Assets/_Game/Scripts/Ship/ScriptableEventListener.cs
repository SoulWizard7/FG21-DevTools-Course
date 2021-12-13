using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScriptableEventListener : MonoBehaviour
{
    [SerializeField] private ScriptableEvents _event;
    [SerializeField] private UnityEvent _response;

    private void OnEventRaised()
    {
        _response.Invoke();
    }

    private void OnEnable()
    {
        _event.Register(OnEventRaised);
    }
    private void OnDisable()
    {
        _event.Unregister(OnEventRaised);
    }
}

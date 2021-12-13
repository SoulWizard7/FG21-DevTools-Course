using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableEvents
{
    public abstract class ScriptableEventBase : ScriptableObject
    {
        private event Action _eventNoPayload;

        public void Register(Action onEventNoPayload)
        {
            _eventNoPayload += onEventNoPayload;
        }

        public void Unregister(Action onEventNoPayload)
        {
            _eventNoPayload -= onEventNoPayload;
        }

        public void Raise()
        {
            _eventNoPayload?.Invoke(); //if event is not null = ?
        }
    }
    [CreateAssetMenu(fileName = "new scriptable event", menuName = "ScriptableObj/ScriptableEvents/newEvent")]
    public class ScriptableEvent : ScriptableEventBase
    {
    }

    public abstract class ScriptableEvent<TPayload> : ScriptableEventBase
    {
        private event Action<TPayload> _event;
        
        public void Register(Action<TPayload> onEventNoPayload)
        {
            _event += onEventNoPayload;
        }

        public void Unregister(Action<TPayload> onEventNoPayload)
        {
            _event -= onEventNoPayload;
        }
    
        public void Raise(TPayload newValue)
        {
            _event?.Invoke(newValue); //if event is not null = ?
        }
        
    }
}
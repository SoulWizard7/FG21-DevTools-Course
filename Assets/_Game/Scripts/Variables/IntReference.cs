using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class IntReference
{
    [SerializeField] private IntVariable _intVariable;
    [SerializeField] private int _simpleValue;

    [SerializeField] private bool _useSimple;

    public int GetValue()
    {
        if (_useSimple)
        {
            return _simpleValue;
        }
        else
        {
            return _intVariable.Value;
        }
    }

    public void ApplyChange(int i)
    {
        if (_useSimple)
        {
            _simpleValue += i;
        }
        else
        {
            _intVariable.ApplyChange(i);
        }
    }
}

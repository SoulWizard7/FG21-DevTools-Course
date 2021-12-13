using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "intVariable", menuName = "ScriptableObj/Variables/IntVariable")]
public class IntVariable : ScriptableObject
{    
    [SerializeField] int _value;

    private int _currentValue;

    public int Value => _currentValue;

    public void ApplyChange(int change)
    {
        _currentValue += change;
    }

    private void OnEnable()
    {
        _currentValue = _value;
    }


    //public class
}

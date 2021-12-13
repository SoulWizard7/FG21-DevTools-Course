using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "floatVariable", menuName = "ScriptableObj/Variables/FloatVariable")]
public class FloatVariable : ScriptableObject
{
    [Range (0f, 10f)]
    [SerializeField] float _value;
    public float Value => _value;
}

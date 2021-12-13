using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ship config", menuName = "ScriptableObj/ShipConfig", order = 2)]
public class ShipConfig : ScriptableObject
{
    [SerializeField] private float _throttle;
    [SerializeField] private float _rotation;
}

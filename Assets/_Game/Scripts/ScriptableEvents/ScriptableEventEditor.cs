using System.Collections;
using System.Collections.Generic;
using ScriptableEvents;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ScriptableEventBase))]
public class ScriptableEventEditor : UnityEditor.Editor
{
    private ScriptableEventBase _target;

    public override void OnInspectorGUI()
    {
        //_target = target as ScriptableEvents;
        _target = (ScriptableEventBase)target;

        base.OnInspectorGUI();

        if (GUILayout.Button("Debug Raise Event"))
        {
            Debug.Log("pressed Button");
            _target.Raise();
        }
        



        // GUILayout
        // EditorGUI
        // EditorGUILayout
    }
}

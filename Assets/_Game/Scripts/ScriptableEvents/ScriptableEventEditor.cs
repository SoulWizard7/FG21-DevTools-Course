using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ScriptableEvents))]
public class ScriptableEventEditor : UnityEditor.Editor
{
    private ScriptableEvents _target;

    public override void OnInspectorGUI()
    {
        //_target = target as ScriptableEvents;
        _target = (ScriptableEvents)target;

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

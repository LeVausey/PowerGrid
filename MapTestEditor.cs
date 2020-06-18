using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(MapTest))]
public class MapTestEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        MapTest myScript = (MapTest)target;
        if (GUILayout.Button("Traverse"))
        {
            myScript.TraversalTest();
        }
    }
}
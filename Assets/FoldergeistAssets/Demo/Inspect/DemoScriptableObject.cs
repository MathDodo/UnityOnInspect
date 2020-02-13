using FoldergeistAssets.Inspect;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DemoScriptableObject", menuName = "DemoScriptableObject", order = 0)]
public class DemoScriptableObject : InspectedSO
{
#if UNITY_EDITOR

    /// <summary>
    /// This method is called in the editor automaticaly if this method is in a class which derives from MonoBehaviour or a class which derives from InspectedSO
    /// </summary>
    private void OnInspect()
    {
        Debug.Log($"Inspecting scriptableobject {name}");
    }

#endif
}
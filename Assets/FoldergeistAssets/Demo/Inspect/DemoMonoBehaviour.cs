using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoMonoBehaviour : MonoBehaviour
{
#if UNITY_EDITOR

    /// <summary>
    /// This method is called in the editor automaticaly if this method is in a class which derives from MonoBehaviour or a class which derives from InspectedSO
    /// </summary>
    private void OnInspect()
    {
        Debug.Log($"Inspecting gameobject: {gameObject.name}");
    }

#endif
}
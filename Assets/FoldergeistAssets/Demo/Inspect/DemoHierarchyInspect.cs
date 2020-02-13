using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoHierarchyInspect : MonoBehaviour
{
#if UNITY_EDITOR

    /// <summary>
    /// This method is called in the editor automaticaly if this method is in a class which derives from MonoBehaviour, when you inspect a gameobject in a hierarchy
    /// </summary>
    private void OnHierarchyInspect()
    {
        Debug.Log($"Inspecting an object in the hierarchy with gameobject {gameObject.name}");
    }

#endif
}
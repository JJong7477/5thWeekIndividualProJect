using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
    public static T FindChildComponent<T>(Transform parent, string name) where T : Component
    {
        foreach (Transform child in parent)
        {
            if (child.name == name)
            {
                return child.GetComponent<T>();
            }

            T result = FindChildComponent<T>(child, name);

            if (result != null)
            {
                return result;
            }
        }
        return null;
    }
}

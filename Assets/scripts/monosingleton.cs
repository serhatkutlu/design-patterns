using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monosingleton<T> : MonoBehaviour where T:monosingleton<T>
{

    private static volatile T instance;
    public static T Ýnstance
    {
        get
        {
            if (instance==null)
            {
                instance = FindObjectOfType(typeof(T)) as T;
            }
            return instance;
        }
        set
        {
           
        }
    }
}

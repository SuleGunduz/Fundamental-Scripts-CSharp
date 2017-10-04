using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfThenStatement : MonoBehaviour
{
    public int myAge = 26;
    void Start()
    {
        if (myAge > 18)
        {
            Debug.Log("I am older than 18");
        }
        else if (myAge<5)
        {
            Debug.Log("less than 5");
        }else
        {
            Debug.Log("invalid");
        }
    }
}
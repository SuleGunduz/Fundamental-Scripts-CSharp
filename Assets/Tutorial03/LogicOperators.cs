using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicOperators : MonoBehaviour {
    public int a;
    public int b;
    public int c;
    public int average;

	// Use this for initialization
	void Start () {

        average = (a + b + c) / 3;

        switch(average)
        {
            case 16:
                Debug.Log("Average is 16");
                break;
            case 10:
                Debug.Log("Average is 10");
                break;
            default:
                Debug.Log("This is the default case");
                break;
        }
	}

    void Update()
    {

    }
	
	
}

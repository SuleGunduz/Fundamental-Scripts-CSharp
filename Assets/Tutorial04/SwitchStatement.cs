using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatement : MonoBehaviour
{

    public int selectedLevel;
    private int easy = 0;
    private int medium = 1;
    private int hard = 2;


    // Use this for initialization
    void Start()
    {
        if (selectedLevel == 0)
        {
            Debug.Log("you selected easy");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{

    public int currentDifficulty;
    public int easy = 0, normal = 1, hard = 2;

    // Use this for initialization
    void Start()
    {
        if (currentDifficulty == easy)
        {
            Debug.Log("you selected Easy");
        }
        else if (currentDifficulty == normal)
        {
            Debug.Log("you selected Normal");
        }
        else
        {
            Debug.Log("you selected HARD");
        }

        switch (currentDifficulty)
        {
            case 0:
                Debug.Log("you selected Easy");
                break;
            case 1:
                Debug.Log("you selected Normal");
                break;
            case 2:
                Debug.Log("you selected HARD");
                break;
            default:
                Debug.Log("Invalid selection");
                break;


        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

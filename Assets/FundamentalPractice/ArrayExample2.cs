using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample2 : MonoBehaviour {

 //   public string[] names = { "John", "Julie", "Mark", "Harison", "George" };
 //   public int[] ages = { 22, 22, 38, 40, 18 };
    // Use this for initialization
    /*void Start () {
        for(int i=0; i<names.Length; i++)
        {
           
            // Debug.Log("My name is" + names[i] + "and I am" + ages[i]);
          //  Debug.Log(names[i]);
          if(i==6)
            {
                continue;
            }else if(i==7)
            {
                Debug.Log(i);
                break;
            }
            Debug.Log(i);
        }
        Debug.Log("You broke the loop early!");

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/

    void Start()
    {
       /* GameObject[] cubeArray = GameObject.FindGameObjectsWithTag("Cube");
        for(int i=0; i<cubeArray.Length;i++)
        {
            cubeArray[i].GetComponent<Renderer>().material.color = Color.red;
        }*/
    }

 void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject[] cubeArray = GameObject.FindGameObjectsWithTag("Cube");
           /* for (int i = 0; i < cubeArray.Length; i++)
            {
                cubeArray[i].GetComponent<Renderer>().material.color = Color.red;
            }*/
            foreach(var cube in cubeArray)
            {
                cube.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}


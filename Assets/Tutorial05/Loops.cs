using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{

    // public int[] numbers = { 5, 6, 7, 8 };


     public int apples = 100;
    //public int i;

    // Use this for initialization
    void Start()
    {
        /*	for(int i=0; i<1; --i)
            {

            }
            Debug.Log(i);
        }*/

        /*  foreach (var number in numbers)
          {
              Debug.Log(number);
          }*/
        /*  while(apples>1)
          {
              Debug.Log(apples);
              apples--;
          }
          Debug.Log("The while loop finished! No crash");*/

        do
        {
            Debug.Log("Apples:" + apples);
            apples--;
        } while (apples >= 1);


    }
}
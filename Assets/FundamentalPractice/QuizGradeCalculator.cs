using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizGradeCalculator : MonoBehaviour
{

    public float quiz1, quiz2, quiz3, quiz4, quiz5;
    public float average;

    void Start()
    {
        quiz1 = Random.Range(0f, 100.1f);
        quiz2 = Random.Range(0f, 100.1f);
        quiz3 = Random.Range(0f, 100.1f);
        quiz4 = Random.Range(0f, 100.1f);
        quiz5 = Random.Range(0f, 100.1f);
        average = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;

        average = Mathf.Round(average * 100) / 100;

        if (average >= 90)
        {
            Debug.Log("you have a A");
        }
        else if (average >= 80 && average < 90)
        {
            Debug.Log("You have B");
        }
        else if (average >= 70 && average < 80)
        {
            Debug.Log("You have C");

        }
        else
        {
            Debug.Log(" You have F");
        }
    }
}

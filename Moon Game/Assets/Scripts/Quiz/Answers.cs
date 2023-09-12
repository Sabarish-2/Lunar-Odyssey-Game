using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Y");
            quizManager.correct();
        }
        else
        { 
            Debug.Log("N");
            quizManager.correct();
        }
    }

}

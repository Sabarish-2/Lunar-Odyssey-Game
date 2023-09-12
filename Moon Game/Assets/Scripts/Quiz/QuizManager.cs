using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QnA> QnAList;
    public GameObject[] options;
    public int CurrentQue;

    public TextMeshProUGUI QuestionText;

    private void Start()
    {
        generateQuestion();

    }

    public void correct()
    {
        QnAList.RemoveAt(CurrentQue);
        generateQuestion();
    }

    void setAns()
    {
        for (int i = 0; i < options.Length; i++) 
        {
            options[i].GetComponent<Answers>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnAList[CurrentQue].Answers[i];

            if (QnAList[CurrentQue].RightAns == i + 1)
            {
                options[i].GetComponent<Answers>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        CurrentQue = Random.Range(0, QnAList.Count);

        QuestionText.text = QnAList[CurrentQue].Question;
        setAns();

        QnAList.RemoveAt(CurrentQue);
    }
}

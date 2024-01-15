using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class QuestionsData
{
    public string question;
    public List<string> options;
    public string correctAnswer;
}


public class QuestionsModel 
{


    public Action<QuestionsData> OnSetQuestionData;
    public Action<bool> OnGetAnswer;
    public Action OnGetCorrectAnswer;


    public List<QuestionsData> questions = new List<QuestionsData>()
    {
        new QuestionsData()
        {
            question = "Test Question 1",
            options = new List<string>()
            {
                "Martin",
                "Luis",
                "Julian"
            },
            correctAnswer = "Julian"

        },
        new QuestionsData()
        {
            question = "What Color is the Sky",
            options = new List<string>()
            {
                "Red",
                "Blue",
                "Green"
            },
            correctAnswer = "Blue"

        },
           new QuestionsData()
        {
            question = "Third Question",
            options = new List<string>()
            {
                "A",
                "B",
                "C"
            },
            correctAnswer = "A"

        },
                   new QuestionsData()
        {
            question = "Fourth Question",
            options = new List<string>()
            {
                "1",
                "2",
                "3"
            },
            correctAnswer = "1"

        }

    };

    public int currentQuestion;


    public void SetDataQuestions()
    {
        var questionsData = questions[currentQuestion];
        OnSetQuestionData.Invoke(questionsData);
    }

    public void GetAnswer(string answer)
    {
        bool result = false;
        if (questions[currentQuestion].correctAnswer == answer)
        {
            result = true;
        }
        else
        {
            result = false;
        }
        OnGetAnswer.Invoke(result); 




    }
 

   
}

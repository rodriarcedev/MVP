using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public interface IQuestionsView 
{

    public TextMeshProUGUI textTitleQuestion
    {
        get;
        set;
    }

    public Button firstOption
    {
        get;
        set;
    }
    public Button secondOption
    {
        get;
        set;
    }
    public Button thirdOption
    {
        get;
        set;
    }

    public Button GetNextQuestion
    {
        get;
        set;
    }

    public GameObject panelResult
    {
        get;
        set;
    }

    public TextMeshProUGUI textResult
    {
        get;
        set;
    }   

    void OnSetdataQuestions(QuestionsData questions);

    void OnQuestionAnsered();
    void OnPressButtonSetAnswer(bool isTrue);

    void OnGetNextQuestion();
   


}

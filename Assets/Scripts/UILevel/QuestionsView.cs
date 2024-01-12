using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class QuestionsView : MonoBehaviour, IQuestionsView
{
    [field: SerializeField]
    public Button firstOption { get; set; }
    [field: SerializeField]
    public Button secondOption { get; set; }
    [field: SerializeField]
    public Button thirdOption { get; set; }
    
    [field: SerializeField]
    public TextMeshProUGUI textTitleQuestion { get; set; }
    [field: SerializeField]
    public GameObject panelResult { get; set; }

    [field: SerializeField]
    public TextMeshProUGUI textResult { get; set; }
    [field: SerializeField]
    public Button GetNextQuestion { get; set; }


    private QuestionsPresenter questionPresenter;




    public void OnQuestionAnsered()
    {
      
    }

    public void OnSetdataQuestions(QuestionsData questions)
    {
        textTitleQuestion.text = questions.question;

        firstOption.onClick.RemoveAllListeners();
        secondOption.onClick.RemoveAllListeners();
        thirdOption.onClick.RemoveAllListeners();


        Debug.Log(questions.options[0]);
        
        firstOption.GetComponentInChildren<TextMeshProUGUI>().text = questions.options[0];
        firstOption.onClick.AddListener(() => questionPresenter.GetAnswer(questions.options[0]));


        secondOption.GetComponentInChildren<TextMeshProUGUI>().text = questions.options[1];

        secondOption.onClick.AddListener(() => questionPresenter.GetAnswer(questions.options[1]));


        thirdOption.GetComponentInChildren<TextMeshProUGUI>().text = questions.options[2];
        thirdOption.onClick.AddListener(() => questionPresenter.GetAnswer(questions.options[2]));

        GetNextQuestion.onClick.AddListener(() => OnGetNextQuestion());

        panelResult.SetActive(false);

    }

    // Start is called before the first frame update
    void Start()
    {
        var model = new QuestionsModel();
        questionPresenter = new QuestionsPresenter(this, model);
        questionPresenter.GetDataQuestion();



    }

  



    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPressButtonSetAnswer(bool isCorrect)
    {

        panelResult.SetActive(true);

       if (isCorrect)
        {
            textResult.text = "Correct";
        }
       else
        {
            textResult.text = "Wrong Answer";
        }
    }

    public void OnGetNextQuestion()
    {
        panelResult.SetActive(false);

        questionPresenter.UpdateQuestionIndex();

        questionPresenter.GetDataQuestion();
    }
}

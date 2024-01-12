using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionsPresenter 
{
    public IQuestionsView questionView;
    public QuestionsModel QuestionModel;
    

    public QuestionsPresenter(IQuestionsView questionView, QuestionsModel model)
    { 
        this.questionView = questionView;
        this.QuestionModel = model;

    }

    public void GetDataQuestion()
    {
        var questions = QuestionModel.questions[QuestionModel.currentQuestion];
     
        questionView.OnSetdataQuestions(questions);
    }

    public void UpdateQuestionIndex()
    {
        QuestionModel.currentQuestion++;
    }



    public void GetAnswer(string answer)
    {
        Debug.Log("The Answer is " + answer + "And the correct Answer is "  + QuestionModel.questions[QuestionModel.currentQuestion].correctAnswer);


        bool result = false;

        if (QuestionModel.questions[QuestionModel.currentQuestion].correctAnswer == answer)
        {
            result = true;
        }
        else
        {
            result = false;
        }


        //foreach (var question in QuestionModel.questions[QuestionModel.currentQuestion].options)
        //{
        //    if (answer == question)
        //    {
        //        result = true;
        //    }
        //}

        questionView.OnPressButtonSetAnswer(result);
      

    }



}

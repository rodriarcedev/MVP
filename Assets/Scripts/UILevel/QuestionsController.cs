using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionsController
{
    public IQuestionsView questionView;
    public QuestionsModel questionModel;



    public QuestionsController(IQuestionsView view, QuestionsModel model)
    {
        this.questionView = view;
        this.questionModel = model;
       


    }


    public void GetDataQuestion()
    {
        var questions = questionModel.questions[questionModel.currentQuestion];
        questionModel.SetDataQuestions();


        //questionView.OnSetdataQuestions(questions);
    }

    public void UpdateQuestionIndex()
    {
        questionModel.currentQuestion++;
    }



    public void GetAnswer(string answer)
    {
        Debug.Log("The Answer is " + answer + "And the correct Answer is " + questionModel.questions[questionModel.currentQuestion].correctAnswer);


        questionModel.GetAnswer(answer);


        //foreach (var question in QuestionModel.questions[QuestionModel.currentQuestion].options)
        //{
        //    if (answer == question)
        //    {
        //        result = true;
        //    }
        //}

        //questionView.OnPressButtonSetAnswer(result);


    }



}




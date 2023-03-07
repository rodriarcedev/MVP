using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthPresenter : IHealthPresenter
{
    private IHealthView healthView;
    private HealthModel healthModel;
    public HealthPresenter(IHealthView view, int health)
    {
        this.healthView = view;
        healthModel = new HealthModel(health);
        SetSliderValue(health);
        healthView.SetMaxHealthValue(health);

    }

    public void GetDamage(int damage)
    {
        healthModel.Health -= damage;
        SetSliderValue(healthModel.Health);
         // Add Method in Health View To Update Slider
         if (healthModel.Health < 0)
        {
            healthView.OnEndGame();
        }
    }

    public void SetSliderValue(int amountValue)
    {
        
        healthView.SetCurrentHealthValue(amountValue);
    }
}

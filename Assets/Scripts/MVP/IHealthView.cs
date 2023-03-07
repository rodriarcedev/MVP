using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealthView 
{
    
    int Health
    {
        get;
        set;
    }
    void OnEndGame();
    void SetCurrentHealthValue(int value);
    void SetMaxHealthValue(int value);
    
}

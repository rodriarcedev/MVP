using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public interface IPlayerMoveView 
{
    public Vector2 XLimits
    {
        get;
        set;
    }
    public Vector2 YLimits
    {
        get;
        set;
    }
    public float SpeedPlayer
    {
        get;
        set;
    }

    Vector2 InputPlayer
    {
        get;
        set;
    }
    void MovePlayerToPosition();
    
}

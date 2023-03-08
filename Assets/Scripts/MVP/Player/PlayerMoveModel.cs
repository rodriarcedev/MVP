using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveModel
{
    public float speedPlayer
    {
        get;
        set;
    }

    public Vector2 xLimits
    {
        get;
        set;
    }
    public Vector2 yLimits
    {
        get; 
        set;
    }
    public PlayerMoveModel(float speedPlayer, Vector2 xLimits, Vector2 yLimits)
    {
        this.speedPlayer = speedPlayer;
        this.xLimits = xLimits;
        this.yLimits = yLimits;
    }

}

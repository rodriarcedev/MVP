using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;
using rodriarce;

public class PlayerMoveView : MonoBehaviour, IPlayerMoveView
{
    public Vector2 InputPlayer // We Get The Playert Inputs Data
    {
        get;
        set;
    }
    public Vector2 XLimits { 
        get
        {
            return xLimits;
        }
        set
        {
            xLimits = value;
        }
            
            }
    public Vector2 YLimits { 
        get
        {
            return yLimits;
        }
        set
        {
            yLimits = value;
        }
    
    }
    public float SpeedPlayer { 
        get
        {
            return speedPlayer;
        }
        set
        {
            speedPlayer = value;
        }

    }
    public Vector2 xLimits;
    public Vector2 yLimits;
    public float speedPlayer;


    public InputActionProperty inputActionPlayer;
    public InputActionProperty leftButtonInput;
    public Action PressButtonAction;
    private PlayerMovePresenter presenter;
    



    private void OnEnable()
    {
        inputActionPlayer.action.Enable();
        leftButtonInput.action.Enable();
        
        

    }

    private void Start()
    {
        presenter = new PlayerMovePresenter(this, speedPlayer, xLimits, YLimits);
        leftButtonInput.action.performed += (context) => { presenter.OnPressedButton(); };
    }

    private void Update()
    {
        InputPlayer = inputActionPlayer.action.ReadValue<Vector2>(); // We Read the Vector2 Value For The inputActionPlayer 
       Vector3 posToMove = presenter.GetPlayerPositionToMove(InputPlayer, transform.position);
        transform.position = posToMove;
    }

    public void MovePlayerToPosition()
    {
        
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class PlayerMoveView : MonoBehaviour, IPlayerMoveView
{
    public Vector2 InputPlayer // We Get The Playert Inputs Data
    {
        get;
        set;
    }
    public InputActionProperty inputActionPlayer;
    public InputActionProperty leftButtonInput;
    public Action PressButtonAction;
    



    private void OnEnable()
    {
        inputActionPlayer.action.Enable();
        leftButtonInput.action.Enable();
        leftButtonInput.action.performed += OnPressedButton;
    }

   
    public void OnPressedButton(InputAction.CallbackContext context)
    {
        // Presenter Code
    }
}

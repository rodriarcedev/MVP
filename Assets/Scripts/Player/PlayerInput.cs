using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

//We Handle here All The Player Inputs 
public class PlayerInput : MonoBehaviour 
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
        leftButtonInput.action.performed += OnPressedMouse;
    }    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputPlayer = inputActionPlayer.action.ReadValue<Vector2>(); // We Read the Vector2 Value For The inputActionPlayer 
        
        
        //Debug.Log(inputActionPlayer.action.ReadValue<Vector2>());
    }
    private void OnPressedMouse(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Press Left Mouse Button");
            PressButtonAction.Invoke();
        }
    }
}

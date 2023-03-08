using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

//We Handle here All The Player Inputs 
public class PlayerInput : MonoBehaviour 
{
    
    
    
    public InputActionProperty leftButtonInput;
    public Action PressButtonAction;



    private void OnEnable()
    {
        
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

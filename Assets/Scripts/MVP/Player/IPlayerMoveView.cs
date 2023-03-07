using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public interface IPlayerMoveView 
{
    Vector2 InputPlayer
    {
        get;
        set;
    }
    void OnPressedButton(InputAction.CallbackContext context);
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerMovePresenter 
{
    void OnPressedButton();
    Vector3 GetPlayerPositionToMove(Vector2 posValue, Vector3 startPosition);

}

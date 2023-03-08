using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEngine.InputSystem;
using Newtonsoft.Json.Linq;

public class PlayerMovePresenter : IPlayerMovePresenter
{
    private PlayerMoveModel playerMoveModel;
    public IPlayerMoveView playerMoveView;
    
    public PlayerMovePresenter(IPlayerMoveView view, float speedPlayer, Vector2 xLimis, Vector2 yLimits)
    {
        playerMoveModel = new PlayerMoveModel(speedPlayer, xLimis, yLimits);
    }

    public void OnPressedButton()
    {
    }

    public Vector3 GetPlayerPositionToMove(Vector2 positionValue, Vector3 startPos)
    {
        
        

        

        if (positionValue.x != 0f && positionValue.y == 0f)
        {
            Debug.Log("YOu Press x Button");
            float xValue = playerMoveModel.speedPlayer * Time.deltaTime * positionValue.x;
            Debug.Log("THe x Value is" + xValue);
            Vector3 valueToMove = new Vector3(startPos.x + xValue, startPos.y, 0);
            Debug.Log("THe x Value Move is " + valueToMove);

            if (valueToMove.x < playerMoveModel.xLimits.x)
            {
                valueToMove = new Vector3(playerMoveModel.xLimits.x, valueToMove.y, valueToMove.z);
            }
            if (valueToMove.x > playerMoveModel.xLimits.y)
            {
                valueToMove = new Vector3(playerMoveModel.xLimits.y, valueToMove.y, valueToMove.z);
            }
            return valueToMove;
        }

        if (positionValue.y != 0f && positionValue.x == 0f)
        {

            float yValue = playerMoveModel.speedPlayer * Time.deltaTime * positionValue.y;
            Vector3 valueToMove = new Vector3(startPos.x, startPos.y + yValue, 0);



            if (valueToMove.y < playerMoveModel.yLimits.x)
            {
                valueToMove = new Vector3(valueToMove.x, playerMoveModel.yLimits.x, valueToMove.z);
            }
            if (valueToMove.y > playerMoveModel.yLimits.y)
            {
                valueToMove = new Vector3(valueToMove.x, playerMoveModel.yLimits.y, valueToMove.z);
            }
            return valueToMove;
        }

        return startPos;
        
    }
}

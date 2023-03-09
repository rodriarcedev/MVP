using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using rodriarce;
using NSubstitute;

public class PlayerMovementTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void PlayerMovementSimplePasses()
    {
        IPlayerMoveView view = Substitute.For<IPlayerMoveView>();
        Vector2 newPosX = new Vector2(-2f, 2f);
        Vector2 newPosY = new Vector2(-4.3f, 4.3f);
        PlayerMovePresenter presenter = new PlayerMovePresenter(view, 10, newPosX, newPosY);
        Vector3 newPosition = new Vector3(newPosX.x, 0, 0);
       Vector3 posToTest =  presenter.GetPlayerPositionToMove(new Vector2(newPosX.x, 0), newPosition);
        Assert.AreEqual(posToTest, newPosition);
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator PlayerMovementWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.TestTools;



public class TestBullets 
{
    [UnityTest]
    public IEnumerator TestPlayerBullets()
    {
        GameObject bullet = new GameObject();
        var damageBullet = bullet.AddComponent<DamageBullet>();
        float posStart = bullet.transform.position.y;
        damageBullet.SpeedDamage = 10f;

        //bullet.AddComponent<DamageBull>
        yield return new WaitForSeconds(1f);
        Assert.Greater(bullet.transform.position.y, posStart);
    }
    [UnityTest]
    public IEnumerator TestEnemyBullet()
    {
        GameObject bullet = new GameObject();
        var damageBullet = bullet.AddComponent<EnemyBullet>();
        float posStart = bullet.transform.position.y;
        damageBullet.SpeedDamage = -10f;

        //bullet.AddComponent<DamageBull>
        yield return new WaitForSeconds(1f);
        Assert.Less(bullet.transform.position.y, posStart);
    }


}

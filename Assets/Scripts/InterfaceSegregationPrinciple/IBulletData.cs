using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBulletDataPlayer // To the BUllet You Shoot
{
    GameObject Bullet
    {
        get;
        set;
    }
    float SpeedShoot
    { get; set; }
    int Damage { get; set; }
    float SpeedBullet { get; set; }
    void CreateBullet();
}


using UnityEngine;

public interface IEnemyDamage
{
    GameObject Bullet
    {
        get;
        set;
    }
    float SpeedShoot
    { get; set; }
   int Damage { get; set; }
   float SpeedBullet { get; set;}
    void ShootBullet(int damage);

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootBullet // Instead of a single script that hanle the damage we add an interface between the bullet and the enemy or the player
{
     float Damage
    {
        get;
        set;
            
    }
     float SpeedDamage
    {
        get;
        set;
    }
    void SetData(float speed, float damage)
    {

    }
}

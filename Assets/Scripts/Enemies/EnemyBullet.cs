using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour, IShootBullet
{
    
    public float Damage
    {
        get;
        set;
    }
    public float SpeedDamage { get;
        set;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetData(float damage, float speed)
    {
        Damage = damage;
        this.SpeedDamage = speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(SpeedDamage * Time.deltaTime * -transform.up);
    }
 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBullet : MonoBehaviour, IShootBullet
{
    public float Damage
    {
        get;
        set;
    }
    public float SpeedDamage { 
        get
        {
            return speedDamage;
        }
        set
        {
            speedDamage = value;
        }
    }
    public float speedDamage;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.up * SpeedDamage * Time.deltaTime);
    }
}

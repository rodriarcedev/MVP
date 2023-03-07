using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBullet : MonoBehaviour, IBulletData
{
    public GameObject Bullet {
        get
        {
            return prefabBullet;
        }            
        set
        {
            prefabBullet = value;
        }
    
    }
    public GameObject prefabBullet;
 
    public int Damage { 
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }
    public int damage;
    public float SpeedBullet {
        get
        {
            return speedBullet;
        }
        set
        {
            speedBullet = value;
        }
    }
    public float speedBullet;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    public void ShootBullet()
    {
        GameObject newProjectile = Instantiate(prefabBullet);
        newProjectile.transform.position = prefabBullet.transform.position;
        newProjectile.GetComponent<DamageBullet>().Damage = Damage;
        newProjectile.SetActive(true);

    }
}

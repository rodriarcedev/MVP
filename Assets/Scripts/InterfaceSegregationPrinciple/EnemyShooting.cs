using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour, IBulletData
{
    public int Damage { get => damage;
                
            
            set
            {
            damage = value;
            }
         }
    public int damage;
    public GameObject bullet;
    public GameObject Bullet { 
        get
        {
            return bullet;
        }
        set
        {
            bullet = value;
        }
    }
    public float speedShoot;
    public float SpeedShoot { 
        get
        {
            return speedShoot;
        }
        set
        {
            speedShoot = value;
        }
            
            }
    public float SpeedBullet { 
        get
        {
            return speedShoot;
        }
        set
        {
            speedShoot = value;
        }
    }

    public float speedBullet; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShootBullets());
    }

    private IEnumerator ShootBullets()
    {
        while (true)
        {
            ShootBullet();
            yield return new WaitForSecondsRealtime(speedShoot);
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShootBullet()
    {
        var newBullet = Instantiate(Bullet);
        newBullet.transform.position = Bullet.transform.position;
        newBullet.GetComponent<IShootBullet>().SetData(Damage, speedBullet);
        newBullet.SetActive(true);

    }
}

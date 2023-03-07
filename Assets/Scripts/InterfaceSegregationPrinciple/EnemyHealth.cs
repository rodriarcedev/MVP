using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, IEnemyHealth
{
    public int health;
    public int Health { get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    public void GetDamage(int damage)
    {
        Health -= (int)damage;
        if (Health <= 0)
        {
            Debug.Log("Death Ship");
            
            StartCoroutine(RegenerateTime());
            
        }
    }

    public IEnumerator RegenerateTime()
    {
        gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(2f);
        gameObject.SetActive(true);
        Health = 100;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("ENemy Get Bullet");
            GetDamage((int)other.GetComponent<IShootBullet>().Damage);
            Destroy(other.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

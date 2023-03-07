using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public Action OnEnemyDeath;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GetDamage(int damage)
    {
        health -= damage;
        if (health <= 0f)
        {
            OnEnemyDeath();
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            Debug.Log("You Touch a Bullet");
            GetDamage((int)other.GetComponent<IShootBullet>().Damage);
            Destroy(other.gameObject);
        }
    }
  

    // Update is called once per frame
    void Update()
    {
        
    }
}

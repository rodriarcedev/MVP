using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour, IHealthView // We Replace the playerhealth script for a IHealthView Script 
{
    public int Health {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }
    public int health;
    private HealthPresenter healthPresenter;
    public GameObject panelEndGame;
    public Slider healthPlayerValue;
    

    

    // Start is called before the first frame update
    void Start()
    {
        healthPresenter = new HealthPresenter(this, Health);
        
    }

    public void SetMaxHealthValue(int value)
    {
        healthPlayerValue.maxValue = value;
        healthPlayerValue.value = value;
    }
    public void SetCurrentHealthValue(int value)
    {
        healthPlayerValue.value = value;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            Debug.Log("You Touch a Bullet");
            
            healthPresenter.GetDamage((int)other.GetComponent<IShootBullet>().Damage);
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEndGame()
    {
        panelEndGame.SetActive(true);
    }
}

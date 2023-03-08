using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
   
    private PlayerInput playerInput;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        playerInput.PressButtonAction += () => { GetComponent<IBulletData>().ShootBullet();};
    }

    //private void CreateProjectile()
    //{
    //    GameObject newProjectile = Instantiate(projectile);
    //    newProjectile.transform.position = projectile.transform.position;
    //    newProjectile.SetActive(true);
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}

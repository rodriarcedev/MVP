using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public BaseBullet baseBullet;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        baseBullet = FindObjectOfType<BaseBullet>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

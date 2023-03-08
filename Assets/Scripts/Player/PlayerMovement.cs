using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ship Movement Script
public class PlayerMovement : MonoBehaviour
{
    public float speedPlayer;
    private PlayerInput playerInput;
    public Vector2 xLimits;
    public Vector2 yLimits;
    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerPosition();
        
        
    }

    private void CheckPlayerPosition()
    {
  
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("You Hit A WAll");
        }

    }
}

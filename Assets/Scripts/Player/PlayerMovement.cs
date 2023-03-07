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
        transform.Translate(playerInput.InputPlayer * speedPlayer * Time.deltaTime);// Makes Player Movement We call the InputPlayer Script
        if (transform.position.x < xLimits.x)
        {
            transform.position = new Vector3(xLimits.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xLimits.y)
        {
            transform.position = new Vector3(xLimits.y, transform.position.y, transform.position.z);
        }
        if (transform.position.y < yLimits.x)
        {
            transform.position = new Vector3(transform.position.x, yLimits.x, transform.position.z);
        }
        if (transform.position.y > yLimits.y)
        {
            transform.position = new Vector3(transform.position.x, yLimits.y, transform.position.z);
        }
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("You Hit A WAll");
        }

    }
}

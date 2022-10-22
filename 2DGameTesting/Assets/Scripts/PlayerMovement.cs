using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Reference to the player's rigidbody - 2d physics of player
    private Rigidbody2D body; 

    //Called every time the script is being loaded
    private void Awake()
    {
        //checks player for rigidbody component, take it, and store it in body 
        body = GetComponent<Rigidbody2D>(); 

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //assigns velocity - speed in 2 directions
        //1st coordinate - left-right
        //2nd coordinate - no changing velocity in y 
        body.velocity = new Vector2(Input.GetAxis("Horizontal"), body.velocity.y);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float speed = 5f;
	private float movement = 0f;
	private Rigidbody2D rigidBody;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        //Debug.Log(movement);
        rigidBody.velocity = new Vector2(movement*speed, rigidBody.velocity.y);
        if (Input.GetKey("left shift"))
        {
            rigidBody.velocity = new Vector2(movement*speed*2, rigidBody.velocity.y);
        }

    }
}

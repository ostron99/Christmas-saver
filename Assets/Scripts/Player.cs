using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour 
{
 int mayShoot = 0;
 public float speed = 0f;
 public float jumpPower;
 public Rigidbody2D movement;
 public bool jump;



 // Use this for initialization
 void Start () 
 {
	movement = GetComponent<Rigidbody2D>();
 }
 
 // Update is called once per frame
 void Update () 

	 {
		if (Input.GetKey(KeyCode.D))
		{
			if (movement.velocity.x < 10)
			{
            movement.AddForce(transform.right * 8.5f);
            }
        }
	

		if (Input.GetKey(KeyCode.A))
		{
			if (movement.velocity.x > -10)
       		{
            	movement.AddForce(transform.right * -8.5f);
       		}
		}

		if (Input.GetKey(KeyCode.Space) && jump == true)
		{
			movement.AddForce(transform.up * 100);
       		jump = false;
		}
 	 }


	void OnCollisionEnter2D (Collision2D Jump)
    {
        if (Jump.gameObject.tag == "Platform")
        {
            jump = true;
        }
    }
 }

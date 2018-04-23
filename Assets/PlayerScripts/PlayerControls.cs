using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public Transform playerTransform;
    public Rigidbody plateRigidbody;
    public int speed;

    public Vector3 offset;

    public Vector3 jumpHeight = new Vector3(0, 6, 0);

    public bool isGrounded = true;
    public bool isWalled = true;

    // Use this for initialization
    void Start ()
	{
	    playerTransform = GetComponent<Transform>();
	    plateRigidbody = GetComponent<Rigidbody>();

	   


    }
	
	// Update is called once per frame
	void Update () {
        //uzstada kontroles
	    Vector3 v = plateRigidbody.velocity;

        if (Input.GetKey(KeyCode.D))
        {
            v.x = 200.0f * Time.deltaTime;
            plateRigidbody.velocity = v;


        }

	    if (Input.GetKey(KeyCode.A))
	    {
	        v.x = -200.0f * Time.deltaTime;
	        plateRigidbody.velocity = v;
        }
        


	    

/*	    if (isGrounded == false)
	    {
	        if (Input.GetKey(KeyCode.Space))
	        {
	            plateRigidbody.velocity = jumpHeight;
	            //isgrounded = false;
	        }
        }*/


	    if (Input.GetButtonDown("Jump") && isGrounded)
	    {
	        plateRigidbody.velocity = jumpHeight;
        }


    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Entered");
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

    }

    void OnCollisionExit(Collision collision)
    {
        //Debug.Log("Exited");
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }


    }


}

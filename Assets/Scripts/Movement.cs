using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	private Rigidbody rb;
	private Vector3 direction;
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}


	public float speed = 1f;
	public 
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		direction = Vector3.ClampMagnitude(Vector3.forward * Input.GetAxis("Vertical") + Vector3.right * Input.GetAxis("Horizontal"), 1f) * speed;
		direction.y = rb.velocity.y;
		rb.velocity = direction;
	}
}

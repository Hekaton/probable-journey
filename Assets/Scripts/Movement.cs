using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	private Rigidbody rb;
	private Vector3 direction;
    public float speed = 1f;
	private float speedMod = 1f;
	
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}


	
	// Update is called once per frame
	void FixedUpdate ()
	{
		
		direction = Vector3.ClampMagnitude(Vector3.forward * Input.GetAxis("Vertical") + Vector3.right * Input.GetAxis("Horizontal"), 1f) * speed * speedMod;
		direction.y = rb.velocity.y;
		rb.velocity = direction;

		var m = GetComponent<MoneyCounter>();
		if (m != null)
		{
			speedMod = 6 / Mathf.Log10(m.GetCash());
		}
	}
}

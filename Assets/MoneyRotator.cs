using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyRotator : MonoBehaviour
{

	[SerializeField] private float speed = 1;

	private Quaternion rotation;
	// Use this for initialization
	void Start () {
		rotation = Quaternion.Euler(Vector3.up * speed);
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.rotation *= rotation;
	}
}

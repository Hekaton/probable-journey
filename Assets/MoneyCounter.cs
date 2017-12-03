using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCounter : MonoBehaviour
{

	public int startingCash = 1000000;
	private float cash = 0;
	// Use this for initialization
	void Start ()
	{
		cash = startingCash;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Gold"))
		{
			cash += other.GetComponent<MonetaryWorth>().getWorth();
		}
		
		Destroy(other.gameObject);
	}

	public float Spend(float amount)
	{
		cash -= amount;
		return cash;
	}
}

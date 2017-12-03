using System;
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

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Gold"))
		{
			var worth = other.GetComponent<MonetaryWorth>().getWorth();
			cash += worth;
		}
		Destroy(other.gameObject);
	}

	public float Spend(float amount)
	{
		cash -= amount;
		return cash;
	}

	public float GetCash()
	{
		return cash;
	}
}

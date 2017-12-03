using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUpdater : MonoBehaviour
{

	[SerializeField] private Text text;
	[SerializeField] private MoneyCounter mc;
	private string displayText;
	
	// Use this for initialization
	void Start ()
	{
		displayText = text.text;
	}
	
	// Update is called once per frame
	void Update ()
	{
		text.text = string.Format(displayText, mc.GetCash());
	}
}

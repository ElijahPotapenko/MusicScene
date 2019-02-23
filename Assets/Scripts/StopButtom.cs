using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;


[Serializable]

public class StopButtom : MonoBehaviour
{
	private SoundElder elder;
	// Use this for initialization
	void Start()
	{
		elder = FindObjectOfType<SoundElder>();
	}

	// Update is called once per frame
	void Update()
	{

	}


	public void onClick()

	{
		elder.stopPlay = true;



	}
}

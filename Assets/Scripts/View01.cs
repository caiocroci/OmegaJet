using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View01 : MonoBehaviour
{

	public Controller01 controller01;

	public void InitializeView()
	{
	//	controller01 = GameObject.FindGameObjectWithTag("Panel1").GetComponent<Controller01>();
	}

	public void buttonView(int parametroView)
	{
		controller01.Evento(ref parametroView);
	}
}

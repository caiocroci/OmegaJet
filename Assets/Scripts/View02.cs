using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View02 : MonoBehaviour
{
	Controller02 controller02;

	public void InitializeView()
	{
		controller02 = GameObject.FindGameObjectWithTag("Painel2 - Tutorial").GetComponent<Controller02>();
	}

	public void buttonView(int parametroView)
	{
		controller02.Evento(ref parametroView);
	}
}

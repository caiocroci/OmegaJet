using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller01 : MonoBehaviour
{
	NavegationManager navegationManager;
	public View01 view01;
	public void InitializeModulo()
	{
		navegationManager = GameObject.FindGameObjectWithTag("Menu Manager").GetComponent<NavegationManager>();
		//view01 = GameObject.FindGameObjectWithTag("Panel1").GetComponent<View01>();

		view01.InitializeView();
	}

	public void Evento(ref int parametroController)
	{
		navegationManager.navegationA(ref parametroController);
	}
}

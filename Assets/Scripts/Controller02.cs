using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller02 : MonoBehaviour
{
	NavegationManager navegationManager;
	View02 view02;
	public void InitializeModulo()
	{
		navegationManager = GameObject.FindGameObjectWithTag("Menu Manager").GetComponent<NavegationManager>();
		view02 = GameObject.FindGameObjectWithTag("Painel2 - Tutorial").GetComponent<View02>();

		view02.InitializeView();
	}

	public void Evento(ref int parametroController)
	{
		navegationManager.navegationA(ref parametroController);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavegationManager : MonoBehaviour
{
	public GameObject panel1;
	public GameObject panel2;

	public Controller01 controller01;
	public Controller02 controller02;

    void Start()
    {
		//panel1 = GameObject.FindGameObjectWithTag("Painel1-Principal");
		//panel2 = GameObject.FindGameObjectWithTag("Painel2 - Tutorial");

		//controller01 = GameObject.FindGameObjectWithTag("Painel1-Princial").GetComponent<Controller01>();
		//controller02 = GameObject.FindGameObjectWithTag("Painel2 - Tutorial").GetComponent<Controller02>();

		controller01.InitializeModulo();
		controller02.InitializeModulo();

		int n = 1;
		navegationA(ref n);
	}

	public void navegationA(ref int parametro)
	{
		HidePanels();
		switch (parametro)
		{
			case 1:
				panel1.SetActive(true);
				break;
			case 2:
				panel2.SetActive(true);
				break;
			default:
				Debug.Log("O painel não existe: " + parametro);
				break;
		}
	}

	void HidePanels()
	{
		panel1.SetActive(false);
		panel2.SetActive(false);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cartera : MonoBehaviour {

	int monedas = 100; // int = No se puede acceder a la variable desde fuera.
	public Text texto_monedas;

	void Update(){
		texto_monedas.text = monedas.ToString ();
	}

	public void donacion (int dinero){
		//if (dinero > 0) { Para asegurarnos que no puede robarle dinero.s
			monedas += dinero;
		//}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladron_script : MonoBehaviour {
	GameObject pringao;
	cartera cartera_pringao;
	// Use this for initialization
	void Start () {
		pringao = GameObject.Find ("ricardito");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Space)) {
			cartera_pringao = pringao.GetComponent<cartera> ();
			cartera_pringao.donacion (-5);
		}
	}
}

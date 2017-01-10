﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class marcador : MonoBehaviour {
	public Text texto_marcador;
	int goles = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (goles >= 1) {
			SceneManager.LoadScene ("nave");
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.transform.name == "balon") {
			goles += 1; //goles = goles +1
			texto_marcador.text = goles + "";
		}
	}
}

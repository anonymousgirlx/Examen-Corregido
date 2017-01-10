using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoJ2 : MonoBehaviour {
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) {
			rb.velocity = new Vector2 (0, 10);
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			rb.velocity = new Vector2 (0, -10);
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			rb.velocity = new Vector2 (-10, 0);
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			rb.velocity = new Vector2 (10, 0);
		}
		//---------------GETKEYUP---------------------

		if (Input.GetKeyUp (KeyCode.W)) {
			rb.velocity = new Vector2 (0, 0);
		}
		if (Input.GetKeyUp (KeyCode.S)) {
			rb.velocity = new Vector2 (0, 0);
		}
		if (Input.GetKeyUp (KeyCode.A)) {
			rb.velocity = new Vector2 (0, 0);
		}
		if (Input.GetKeyUp (KeyCode.D)) {
			rb.velocity = new Vector2 (0, 0);
		}
	}
}

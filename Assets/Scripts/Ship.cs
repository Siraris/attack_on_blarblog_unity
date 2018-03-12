using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) {
			transform.position = new Vector3(0f, 0f, 5f);
		} else if (Input.GetKey(KeyCode.S)) {
			transform.position = new Vector3(0f, 0f, -5f);
		}
	}
}

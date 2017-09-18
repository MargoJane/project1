using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {

	bool printedMessage;

	// Use this for initialization
	void Start () {
		
		printedMessage = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > 3 && printedMessage == false) {
			print("It's been 3 seconds!");
			printedMessage = true;
		}
	}
}
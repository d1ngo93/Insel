using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(0, 0, 90 *Time.deltaTime);


	}
}
// Hier sehen wir bei transform.Rotate wie man einen Gegenstand um seine Achsen routieren lässt.
// Da wir nur wollen das sich die Münzen seitlich drehen sind die ersten Werte auf 0 und der letzte auf 90 
// gestezt.
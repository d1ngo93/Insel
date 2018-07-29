using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour {

// Initialisieren der Geschwindigkeit und des Winkels, bei dem die Bewegung gestartet werden soll
	public Transform vrCamera;
	public float toggleAngle = 30.0f;
	public float speed = 3.0f;
	public bool moveForward;

	private CharacterController cc;

	// Bei der Bewegung wird auf den Charactercontroller zurückgegriffen, weil dort schon einige Voreinstellungen hinterlegt sind.
	void Start()
	{
		cc = GetComponent<CharacterController>();
	}

	// Update is called once per frame / Es wird größtenteils auf bereits bestehende Funktionen in Unity zurück gegriffen. Mit if/else wird anhand des Kamerawinkels
	// geprüft, ob die SimpleMove-Funktion ausgelöst werden soll.
	void Update()
	{
		if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
		{
			moveForward = true;
		}
		else
		{
			moveForward = false;
		}

		if (moveForward )
		{
			Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

			cc.SimpleMove(forward * speed);
		}
	}
}
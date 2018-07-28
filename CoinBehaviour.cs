using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
  

	void OnTriggerEnter(Collider collider)
    {
        CoinCounter.coinCount++;

        Destroy(gameObject);
    }
}
// OnTriggerEnter (Collider collider) soll ein Event auslösen sobald man mit dem Collider der Münzen
// in Berührung kommt. CoinCounter.coinCount++ lässt dann die Münzen für den Counter addieren damit man
// weiß wie viele Münzen man hat. Destroy (gameObject) lässt die Münze dann verschwinden.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprechblasepop : MonoBehaviour {

    public GameObject uiObject;
	void Start () 
    {
        uiObject.SetActive(false);
	}
    void OnTriggerEnter(Collider FPSController)
    {
        if (FPSController.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(10);
        Destroy(uiObject);
    }

}
//im folgendem sieht man mit onTriggerEnter Collider FPSController ein Event das stattfindet sobald 
// der Spieler bzw. FPSController mit einem Object zusammenstößt. In diesem Moment aktiviert StartCoroutine
// eine WaitForSec Aktion, die einem einen Text ausgibt der in yield return new WaitForSeconds (10)
// genau 10 Sekunden angezeigt wird. Die Sprechblase und die Zeit der Anzeige kann in dieser Klammmer somit
// individuell angepasst werden. Dies ist hilfreich wenn der Text der Sprechblase groß ist und der Spieler
// somit etwas mehr Zeit benötigt um alles lesen zu können.
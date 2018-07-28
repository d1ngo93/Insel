using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Activate : MonoBehaviour {

    public GameObject Block;



	void Start () {
		
	}
	

	void Update () {
		
        if (CoinCounter.coinCount == 5)
        {
            Destroy(Block);
        }

	}
}

// Anbei wird mit if CoinCounter == 5 ein event geschaffen das ausgelöst wird sobald alle 5
// Münzen eingesammelt wurden, in diesem Fall Destroy(Block), der einen unsichtbaren Block vor dem Portal
// zerstört um dieses zu aktivieren
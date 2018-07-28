using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour {
    
    public static int coinCount = 0;

	void OnGUI()
	{
        string coinText = "Coins:" + coinCount;

        GUI.Box(new Rect(Screen.width - 350, 20, 130, 20), coinText);

    }
}
// string coinText = "Coins" + CoinCount zeigt einfach den Text der rechts oben im Counter angezeigt wird
// + die Anzahl der bereits gesammelten Münzen. GUI.Box bestimmt die Position der Coin Counter Box auf dem 
// Screen.
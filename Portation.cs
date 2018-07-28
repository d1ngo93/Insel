using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portation : MonoBehaviour {
    public Transform spawnPoint;


    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = spawnPoint.position;

    }

  
}
// Anbei finden wir die Funktion der Portale. Wenn man diese Betritt bzw. deren Collider berührt
// wird man mit transform.position zu einem anderen spawnPoint gebracht. Dieser wird im Grunde vorher in 
// in Unity mit einem weiterem Portal gekennzeichnet, damit man weiß wo man rauskommt wenn man das erste Portal
// betritt.
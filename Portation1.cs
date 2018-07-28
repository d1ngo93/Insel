using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portation1 : MonoBehaviour{
    public Transform spawnPoint1;


    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = spawnPoint1.position;

    }


}
// siehe script zu Portal 
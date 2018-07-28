using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Durch dieses Script "Bewegt" sich das Wasser (Manipulation der Eckpunkte)

public class MakeSomeNoise : MonoBehaviour {

    // Diese drei Variablen können später noch im Inspector verändert werden, um den gewünschten Effekt zu haben.
    public float power = 3;
    public float scale = 1;
    public float timeScale = 1;

    // Diese Variablen beschreiben die Veränderung der x und y Achse
    private float xOffset;
    private float yOffset;
    private MeshFilter mf;

    // Use this for initialization (vorgegeben von unity)
    void Start()
    {
        mf = GetComponent<MeshFilter>();
        MakeNoise(); // funktion die verschiedenen Eckpunkte und ihre Position in der Welt ausrechnet.
    }

    // Update is called once per frame (vorgegeben von unity)
    void Update()
    {
        MakeNoise();
        xOffset += Time.deltaTime * timeScale; // Time.deltaTime beschreibt die Zeit, wie lange zwischen zwei Frames lag (sekunden) 
        if (yOffset <= 0.1) yOffset += Time.deltaTime * timeScale;  
        if (yOffset >= power) yOffset -= Time.deltaTime * timeScale;
    }

    void MakeNoise()
    {
        Vector3[] verticies = mf.mesh.vertices; // Array in dem wir auf die Eckpunkte aus unserem mesh im meshfilter zugreifgen

        for (int i = 0; i < verticies.Length; i++)
        {
            verticies[i].y = CalculateHeight(verticies[i].x, verticies[i].z) * power; // Wir nehmen den Eckpunkt (vertices) der gerade im loop an der Reihe ist und manipulieren dessen y Achse (Höhe)
        }

        mf.mesh.vertices = verticies;
    }

    float CalculateHeight(float x, float y) // berechnet wie weit die y Koordinate in einer bestimmten zeeit verschoben werden soll (Höhe) Wird Oben in der MakeNoise Funktion aufgerufen
    {
        float xCord = x * scale + xOffset;
        float yCord = y * scale + xOffset;

        return Mathf.PerlinNoise(xCord, yCord); // Perlin Noise ist ein semi-zufälliges Muster welches aus float values, also sich stetig verändernden Werten, besteht. Dieses Muster ist 2 demensional wesswegen die Höhe extra berechnet werden muss
    }
}

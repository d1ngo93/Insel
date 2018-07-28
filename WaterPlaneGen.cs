using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Dieses script generiert eine Fläche, auf der die Eckpunkte des Polygonwassers manipuliert werden können

public class WaterPlaneGen : MonoBehaviour
{

    public float size = 1;
    public int gridSize = 16;

    private MeshFilter filter;

    private void Start()
    {
        filter = GetComponent<MeshFilter>();
        filter.mesh = GenerateMesh();
    }

    // Ab hier wird das Netz/Mesh erstellt
    private Mesh GenerateMesh()
    {
        Mesh m = new Mesh();

        var verticies = new List<Vector3>(); // Vector 3 wird gebraucht, da wir das Mesh durch die Eckpunkte auf der x,y,z Achse verändern wollen
        var normals = new List<Vector3>();
        var uvs = new List<Vector2>(); // uvs sind eine Fläche, haben daher nur zwei Dimensionen (nur x,z da y die Höhe bestimmt)

        for (int x = 0; x < gridSize + 1; x++) // for loop für die Variablen x und y zur Erstellung der individuellen Flächen. Läuft bis x größer als gridSzie + 1 ist
        {
            for (int y = 0; y < gridSize + 1; y++)
            {
                verticies.Add(new Vector3(-size * 0.5f + size * (x / ((float)gridSize)), 0, -size * 0.5f + size * (y / ((float)gridSize)))); //hier wird die Höhe generiert
                normals.Add(Vector3.up); // up bedeutet, das der Vector immer nach oben deutet aka die Wellen gehen nach oben
                uvs.Add(new Vector2(x / (float)gridSize, y / (float)gridSize));
            }
        }

        // die Dreiecke welche die Wellen darstellen sollen werden generiert
        // dafür werden die vier Punkte der Plane geteilt, so das zwei Dreiecke entstehen
        var triangles = new List<int>();
        var vertCount = gridSize + 1;
        for (int i = 0; i < vertCount * vertCount - vertCount; i++)
        {
            if ((i + 1) % vertCount == 0)
            {
                continue;
            }
            triangles.AddRange(new List<int>(){
                i+1+vertCount, i+vertCount, i,
                i, i+1, i+vertCount+1
            });
        }

        // garb mesh durch die Variable m und befüllen die Vectoren vertices/normals/uvs/triangels mit den Werten aus den vorher aufgebauten Listen
        m.SetVertices(verticies);
        m.SetNormals(normals);
        m.SetUVs(0, uvs);
        m.SetTriangles(triangles, 0);

        // Ausgabe unseres Mesh "m" aka die Plane auf der die Dreicke existieren, die mit dem "MakeSomeNoise" script manipuliert werden
        return m;
    }
}

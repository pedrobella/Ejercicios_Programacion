using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 
public class Ejercicio09 : MonoBehaviour
{
    public GameObject[] gos;

    // Start is called before the first frame update
    void Start()
    {
        gos = new GameObject[12];

        for (int i = 0; i < gos.Length; i++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            gos[i] = sphere;

            if (i > 0)
            {
                gos[i].transform.localScale = gos[i - 1].transform.localScale * 2;
            }
        }
    }
}


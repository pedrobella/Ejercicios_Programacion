using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{

    public GameObject[] gos;
    // Start is called before the first frame update
    void Start()
    {
        gos = new GameObject[30];
        for (int i = 0; i < gos.Length; i++)
        {
            GameObject nuevos = new GameObject();
            gos[i] = nuevos;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

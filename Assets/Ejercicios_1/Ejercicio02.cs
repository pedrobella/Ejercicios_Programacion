using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ejercicios_1;

public class Ejercicio02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        GameObject go1 = new GameObject("nuevo");
        go1.transform.position = new Vector3(111.1f, -5f, 4.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

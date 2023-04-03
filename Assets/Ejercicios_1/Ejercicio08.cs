using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio08 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.transform.position = new Vector3(-0.5f, 0.5f, 0);

        GameObject cubo2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo2.transform.position = new Vector3(1, 1, 0);
        cubo2.transform.localScale = Vector3.one * 2f;

        GameObject cubo3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo3.transform.position = new Vector3(4, 2, 0);
        cubo3.transform.localScale = Vector3.one * 4f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

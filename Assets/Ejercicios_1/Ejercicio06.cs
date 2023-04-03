using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio06 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        esfera.transform.position = new Vector3(50, 0, 0);

        GameObject esfera2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        esfera2.transform.position = new Vector3(-50, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

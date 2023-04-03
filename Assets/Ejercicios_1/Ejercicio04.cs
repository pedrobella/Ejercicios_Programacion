using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        Rigidbody body = esfera.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

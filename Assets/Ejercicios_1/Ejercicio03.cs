using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ejercicios_1;

public class Ejercicio03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.transform.localScale = Vector3.one * 2f;


    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere dos esferas al inicio separadas 100 metros
    /// </summary>
    public class Ejercicio06 : MonoBehaviour
    {
        void Start()
        {
            GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esfera.transform.position = new Vector3(50f, 0f, 0f);

            GameObject esfera2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esfera2.transform.position = new Vector3(-50f, 0f, 0f);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere tres esferas al inicio separadas 100 metros
    /// </summary>
    public class Ejercicio07 : MonoBehaviour
    {
        void Start()
        {
            GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esfera.transform.position = new Vector3(50, 0, 0);

            GameObject esfera2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esfera2.transform.position = new Vector3(-50, 0, 0);

            GameObject esfera3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esfera3.transform.position = new Vector3(0, 0, 50);
        }

        //❕
        void CrearEsferas()
        {                    
            for (int i = 0; i < 3; i++)
            {
                GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                esfera.transform.position = Vector3.right * i * 100f;
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere 12 esferas cada una el doble de grande que la anterior
    /// </summary>
    public class Ejercicio09 : MonoBehaviour
    {
        public GameObject[] gos;

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

            //❕ Ejercicio08.CrearFiguras(PrimitiveType.Sphere, 12);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que cambie el nombre de todos los GameObjects de la escena en base a un atributo definido en este
    /// </summary>
    public class Ejercicio10 : MonoBehaviour
    {
        //public GameObject[] gos;
        //❕
        public string nombre;

        void Start()
        {
            //❗️
            /*
            gos = new GameObject[12];

            for (int i = 0; i < gos.Length; i++)
            {
                GameObject esferas = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                gos[i] = esferas;

                gos[i].name = "nombre" + i;

                if (i > 0)
                {
                    gos[i].transform.localScale = gos[i - 1].transform.localScale * 2;
                    gos[i].name = "nombre" + i;
                }
            }
            */

            GameObject[] todos = GameObject.FindObjectsOfType<GameObject>();
            foreach(GameObject go in todos) {
                go.name = nombre;
            }
        }
    }
}
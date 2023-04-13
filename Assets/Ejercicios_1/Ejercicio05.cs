using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere 30 GameObjects al inicio
    /// </summary>
    public class Ejercicio05 : MonoBehaviour
    {
        public GameObject[] gos;
        void Start()
        {
            gos = new GameObject[30];
            for (int i = 0; i < gos.Length; i++)
            {
                gos[i] = new GameObject();
            }
        }
    }
}
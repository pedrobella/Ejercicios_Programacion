using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere un cubo al inicio y duplique su escala
    /// </summary>
    public class Ejercicio03 : MonoBehaviour
    {
        void Start()
        {
            GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubo.transform.localScale = Vector3.one * 2f;
            //❕ cubo.transform.localScale *= 2f;
        }
    }
}
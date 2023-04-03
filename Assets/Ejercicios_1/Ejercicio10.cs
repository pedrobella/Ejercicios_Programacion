using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Crear un script que cambie el nombre de tods los GameObjects de la escena en base a un atributo definido en este
public class Ejercicio10 : MonoBehaviour
{
    public GameObject[] gos;

    // Start is called before the first frame update
    void Start()
    {
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

    }

}

 
    
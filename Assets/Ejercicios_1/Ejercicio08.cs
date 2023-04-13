using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere tres cubos cada uno el doble de grande que el anterior
    /// </summary>
    public class Ejercicio08 : MonoBehaviour
    {
        void Start()
        {
            GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubo.transform.position = new Vector3(-0.5f, 0.5f, 0);

            GameObject cubo2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubo2.transform.position = new Vector3(1, 1, 0);
            cubo2.transform.localScale = Vector3.one * 2f;

            GameObject cubo3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubo3.transform.position = new Vector3(4, 2, 0);
            cubo3.transform.localScale = Vector3.one * 4f;

            //❕ CrearFiguras(PrimitiveType.Cube, 3);
        }

        //❕
        public static void CrearFiguras(PrimitiveType figura, int cantidad, float separacion = 0f)
        {
            float x = -0.5f; //Para que el primero se dibuje en (0, 0, 0)
            for (int i = 0; i < cantidad; i++)
            {
                GameObject cubo = GameObject.CreatePrimitive(figura);
                float size = Mathf.Pow(2f, i); //1, 2, 4, 8, 16
                cubo.transform.localScale = Vector3.one * size;
                x += size/2f; //Empujamos el punto de creación la mitad del tamaño que tiene
                cubo.transform.position = new Vector3(x, 0f, 0f);
                x += size/2f; //Empujamos la otra mitad para retomar desde ahí en el próximo
                x += separacion; //Añadimos la separación que queremos entre cubos
            }
        }
    }
}
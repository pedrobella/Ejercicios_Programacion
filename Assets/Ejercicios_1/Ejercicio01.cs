using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere un GameObject al inicio cuyo nombre sea "Ejercicio01"
    /// </summary>
    public class Ejercicio01 : MonoBehaviour
    {
        void Start()
        {
            GameObject go1 = new GameObject();
            //❕
            //Opción 1:
            //go1.name = "Ejercicio01";
            //Opción 2:
            //GameObject go1 = new GameObject("Ejercicio01");
        }

    }
}

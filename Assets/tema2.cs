using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tema2 : MonoBehaviour
{
    public string nombre;
    public int anio;
    public string orientacion;

    // Start is called before the first frame update
    void Start()
    {
        if (nombre == "")
        {
            Debug.Log("ERROR, falta completar un campo");
        }

        else if (anio > 5 && anio < 1)
        {
            Debug.Log("El año ingresado no es valido");
        }
        else if (anio > 3)
        {
            Debug.Log("Error, aun estas en ciclo basico");
        }
        else
        {
            switch (orientacion)
            {
                case "T":Debug.Log("Muchas gracias " + nombre);
                    break;
                case "D":
                    Debug.Log("Muchas gracias " + nombre);
                    break;
                case "G":
                    Debug.Log("Muchas gracias " + nombre);
                    break;
                case "M":
                    Debug.Log("Muchas gracias " + nombre);
                    break;
                case "H":
                    Debug.Log("Muchas gracias " + nombre);
                    break;
                default:
                    Debug.Log("Solo se puede ingresar: T, D, G, M o H");
                    break;
            }
        }
    
    }
     

    

    // Update is called once per frame
    void Update()
    {
        
    }
}

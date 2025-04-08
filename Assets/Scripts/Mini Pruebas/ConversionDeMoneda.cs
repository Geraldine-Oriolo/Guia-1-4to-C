using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    //1. Declaración de variables

    public float montoAConvertir;
    public string codigoMoneda;
    //No requiero que sea publico el monto, no quiero q sea cambiado x el inspector  

    float montoConvertido;
    float cotizacionMonedaElegida;

    // Start is called before the first frame update
    void Start()
    {
      //2. Ingreso y validación de datos
        
        if(montoAConvertir < 1000)
        {
            Debug.Log("El monto mínimo es $1000");
            //return devuelve el dato (termina la funcion)
            return;
        }

        if (codigoMoneda == "D")
        {
            cotizacionMonedaElegida = 1134.5f;
        } else if (codigoMoneda == "E")
        {
            cotizacionMonedaElegida = 1397.16f;
        }else if (codigoMoneda == "R")
        {
            cotizacionMonedaElegida = 211.1f;
        }else
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }


        //3. Operaciones y procesamiento de datos
        montoConvertido = montoAConvertir / cotizacionMonedaElegida;

        //4. Salida de datos
        Debug.Log("Monto convertido: " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

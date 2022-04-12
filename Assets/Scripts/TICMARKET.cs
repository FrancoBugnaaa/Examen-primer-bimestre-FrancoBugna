using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TICMARKET : MonoBehaviour
{
    public string nomprodu1;
    public string nomprodu2;
    public string nomprodu3;
    public float precio1;
    public float precio2;
    public float precio3;
    public int cant1;
    public int cant2;
    public int cant3;
    float total1;
    float total2;
    float total3;
    float totaldesc;
    float montototcon20_1;
    float montototcon20_2;
    float montototcon20_3;
    // Start is called before the first frame update
    void Start()
    {
        total1 = precio1 * cant1;
        total2 = precio2 * cant2;
        total3 = precio3 * cant3;
        totaldesc = ((total1 + total2 + total3) * 0.2f);
        if (cant1 >= 3)
        {
            Debug.Log("Tiene que pagar $" + precio1 * 0.2f + "menos por el ter er producto");
        }
        if (cant2 >= 3)
        {
            Debug.Log("Tiene que pagar $" + precio2 * 0.2f + "menos por el ter er producto");
        }
        if (cant3 >= 3)
        {
            Debug.Log("Tiene que pagar $" + precio3 * 0.2f + "menos por el ter er producto");
        }
        if (cant1 <= 0 || cant2 <= 0 || cant3 <= 0)
        {
            Debug.Log("El numero ingresado es erroneo la cantidad tiene que ser igual a 1 o mayor");
        }
        if (precio1 <= 0 || precio2 <= 0 || precio3 <= 0)
        {
            Debug.Log("El numero ingresado es erroneo el precio tiene que ser igual a 1 o mayor");
        }
        Debug.Log("La cantidad de productos comprados es " + (cant1 + cant2 + cant3) + " el precio total sin descuento es $" + (total1 + total2 + total3) + " Te ahorras $" + (precio1 * 0.2f + precio2 * 0.2f + precio3 * 0.2f) + " gracias al descuento" + "El total con descuento seria $" + totaldesc);

    }


    // Update is called once per frame
    void Update()
    {

    }
}

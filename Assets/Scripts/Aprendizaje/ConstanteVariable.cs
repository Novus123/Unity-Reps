using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstanteVariable : MonoBehaviour
{
    //Cantidad salud total
    public int saludPersonaje = 100;
    //Cantidad restada salud
    public int deterioroSalud = 10;

    public string nombrePersonaje = "Bonnie";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Salud Inicial: " + saludPersonaje);

        Debug.Log("Daño que recibe: " + deterioroSalud);
        Debug.Log(saludPersonaje - deterioroSalud);
        Debug.Log("El nombre del personaje es: " + nombrePersonaje);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

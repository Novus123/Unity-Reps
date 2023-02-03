using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeerInput : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Text componenteTexto = null;

    private string dato1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IngresarDato1 (string ingreso)
    {
        dato1 = ingreso;
        Debug.Log(dato1);
    }

    public void AlgoritmoEjercicio()
    {
        string resultado = "Hola, " + dato1 + "!";
        componenteTexto.text = resultado;
    }
}

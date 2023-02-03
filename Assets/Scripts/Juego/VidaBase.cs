using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaBase : MonoBehaviour
{
    [SerializeField] protected float saludInicial;
    [SerializeField] protected float saludMax;


    public int MyProperty { get; set; }

    public float Salud { get; protected set; }
    // Start is called before the first frame update
    protected virtual void Start()
    {
        Salud = saludInicial;
    }
     public void RecibirDa�o(float cantidad)
    {
        if (cantidad <= 0)
        {
            return;
        }

        if (Salud > 0)
        {
            Salud -= cantidad;
            ActualizarBarraVida(Salud, saludMax);
            if(Salud <= 0)
            {
                ActualizarBarraVida(Salud, saludMax);
                PersonajeDerrotado();
            }
        }
    }

    protected virtual void ActualizarBarraVida(float vidaActual, float vidaMax)
    {

    }

    protected virtual void PersonajeDerrotado()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

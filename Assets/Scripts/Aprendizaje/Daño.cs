using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaRestante : MonoBehaviour

{
    public int vidaSalud = 100;
    public int dmgProyectil = 10;

        void Start()
        {dmgRecibido();}

        void dmgRecibido()
        {int saludRestante = vidaSalud - dmgProyectil;
         Debug.Log("La salud restante es: " + saludRestante + " HP");}

        void Update()
        {}
}

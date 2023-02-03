using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuJuego : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Nivel1()
    {
        SceneManager.LoadScene("Nivel1");
    }
    public void Nivel2()
    {
        SceneManager.LoadScene("Nivel2");
    }
     public void Salir()
    {
        Application.Quit();
    }
}



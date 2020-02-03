using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Play()
    {
        if(MenuOpciones.esp)
            SceneManager.LoadScene("CinematicaPrincipioEspañol");
        else
            SceneManager.LoadScene("CinematicaPrincipio");
    }

    public void CloseApp()
    {
        Application.Quit();
    }

    public void Options()
    {
        if (MenuOpciones.esp)
            SceneManager.LoadScene("MenuOpcionesEspañol");
        else
            SceneManager.LoadScene("MenuOpciones");
    }


}
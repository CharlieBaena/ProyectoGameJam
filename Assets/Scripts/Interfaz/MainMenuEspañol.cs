using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuEspañol : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("CinematicaPrincipio");
    }

    public void CloseApp()
    {
        Application.Quit();
    }

    public void Options()
    {
        SceneManager.LoadScene("MenuOpcionesEspañol");
    }


}
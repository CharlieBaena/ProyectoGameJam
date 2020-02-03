using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOpcionesEspañol : MonoBehaviour
{
    public static bool esp;
    bool isMute;

    
    private void Start()
    {
        esp = true;
    }
    public void Return()
    {
        SceneManager.LoadScene("MenuPrincipalEspañol");
    }
    public void FullScreen()
    {
        if ( Screen.fullScreen)
        {
            Screen.SetResolution(1920, 1080, false);
        }
        else
        {
            Screen.SetResolution(1920, 1080, true);
        }
   }
    public void Mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
    }

    public void CambiarAIngles()
    {
        esp = false;
        SceneManager.LoadScene("MenuOpciones");
    }


}

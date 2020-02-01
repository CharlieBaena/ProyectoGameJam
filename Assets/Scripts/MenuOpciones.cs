using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOpciones : MonoBehaviour
{
    bool isMute;

    // Start is called before the first frame update
    public void Return()
    {
        SceneManager.LoadScene("MenuPrincipal");
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

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class IniciarCinematica : MonoBehaviour
{
    public RawImage fondo;
    public VideoPlayer videoPlayer;
    public AudioSource audioSource;
    private void Start()
    {
        StartCoroutine(PlayVideo());
    }

    public IEnumerator PlayVideo()
    {
        videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while (!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        fondo.texture = videoPlayer.texture;
        videoPlayer.Play();
        audioSource.Play();
        while (videoPlayer.isPlaying)
        {
            yield return waitForSeconds;
            break;
        }
        //SceneManager.LoadScene("InterfazDePuzzle");
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class StreamVideo : MonoBehaviour
{
    public RawImage fondo;
    public VideoPlayer videoPlayer;
    //public AudioSource audioSource;

    // Start is called before the first frame update
    void Start() {
        StartCoroutine(PlayVideo());
    }

    public IEnumerator PlayVideo() {
        videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while (!videoPlayer.isPrepared) {
            yield return waitForSeconds;
            break;
        }
        fondo.texture = videoPlayer.texture;
        fondo.gameObject.SetActive(true);
        videoPlayer.Play();
        //audioSource.Play();
    }


}

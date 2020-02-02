using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class StreamVideo : MonoBehaviour
{
    public RawImage fondo;
    public VideoPlayer videoPlayer;

    Puzzle puzzle;
    //public AudioSource audioSource;

    // Start is called before the first frame update
    /*void Start() {
        StartCoroutine(PlayVideo());
    }*/

    private void Awake()
    {
        puzzle = GameObject.Find("Scripts").GetComponent(typeof(Puzzle)) as Puzzle;
    }

    private void FixedUpdate()
    {
        print(puzzle.puzzleResuelto);
        if(puzzle.puzzleResuelto)
            StartCoroutine("PlayVideo");
    }

    public IEnumerator PlayVideo() {
        print("entro");
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

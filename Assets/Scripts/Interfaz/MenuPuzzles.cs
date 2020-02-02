using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuPuzzles : MonoBehaviour
{
    public Transform button1;
    public Transform button2;
    public Transform button3;
    public Transform button4;
    public Transform button5;
    public Transform button6;
    public Transform button7;


    [HideInInspector]
    public static int puzzlesResueltos  =  0;

  

    void Start()
    {
        /*button2.GetComponent<Button>().interactable = false;
        button3.GetComponent<Button>().interactable = false;
        button4.GetComponent<Button>().interactable = false;
        button5.GetComponent<Button>().interactable = false;
        button6.GetComponent<Button>().interactable = false;
        button7.GetComponent<Button>().interactable = false;
        button7.gameObject.SetActive(false);  */                  //button7 empieza desactivado

        if (puzzlesResueltos == 0)
        {
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            button4.gameObject.SetActive(false);
            button5.gameObject.SetActive(false);
            button6.gameObject.SetActive(false);
            button7.gameObject.SetActive(false);
            button2.GetComponent<Button>().interactable = false;
            button3.GetComponent<Button>().interactable = false;
            button4.GetComponent<Button>().interactable = false;
            button5.GetComponent<Button>().interactable = false;
            button6.GetComponent<Button>().interactable = false;
            button7.GetComponent<Button>().interactable = false;
        }

        if(puzzlesResueltos == 1)
        {
            button1.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            button4.gameObject.SetActive(false);
            button5.gameObject.SetActive(false);
            button6.gameObject.SetActive(false);
            button7.gameObject.SetActive(false);
            button1.GetComponent<Button>().interactable = false;
            button3.GetComponent<Button>().interactable = false;
            button4.GetComponent<Button>().interactable = false;
            button5.GetComponent<Button>().interactable = false;
            button6.GetComponent<Button>().interactable = false;
            button7.GetComponent<Button>().interactable = false;
        }

        if (puzzlesResueltos == 2)
        {
            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            button4.gameObject.SetActive(false);
            button5.gameObject.SetActive(false);
            button6.gameObject.SetActive(false);
            button7.gameObject.SetActive(false);
            button1.GetComponent<Button>().interactable = false;
            button2.GetComponent<Button>().interactable = false;
            button4.GetComponent<Button>().interactable = false;
            button5.GetComponent<Button>().interactable = false;
            button6.GetComponent<Button>().interactable = false;
            button7.GetComponent<Button>().interactable = false;
        }

        if (puzzlesResueltos == 3)
        {
            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            button5.gameObject.SetActive(false);
            button6.gameObject.SetActive(false);
            button7.gameObject.SetActive(false);
            button1.GetComponent<Button>().interactable = false;
            button2.GetComponent<Button>().interactable = false;
            button3.GetComponent<Button>().interactable = false;
            button5.GetComponent<Button>().interactable = false;
            button6.GetComponent<Button>().interactable = false;
            button7.GetComponent<Button>().interactable = false;
        }

        if (puzzlesResueltos == 4)
        {
            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            button4.gameObject.SetActive(false);
            button6.gameObject.SetActive(false);
            button7.gameObject.SetActive(false);
            button1.GetComponent<Button>().interactable = false;
            button2.GetComponent<Button>().interactable = false;
            button3.GetComponent<Button>().interactable = false;
            button4.GetComponent<Button>().interactable = false;
            button6.GetComponent<Button>().interactable = false;
            button7.GetComponent<Button>().interactable = false;
        }

        if (puzzlesResueltos == 5)
        {
            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            button4.gameObject.SetActive(false);
            button5.gameObject.SetActive(false);
            button7.gameObject.SetActive(false);
            button1.GetComponent<Button>().interactable = false;
            button2.GetComponent<Button>().interactable = false;
            button3.GetComponent<Button>().interactable = false;
            button4.GetComponent<Button>().interactable = false;
            button5.GetComponent<Button>().interactable = false;
            button7.GetComponent<Button>().interactable = false;
        }

        if (puzzlesResueltos == 6)
        {
            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            button4.gameObject.SetActive(false);
            button5.gameObject.SetActive(false);
            button6.gameObject.SetActive(false);
            button1.GetComponent<Button>().interactable = false;
            button2.GetComponent<Button>().interactable = false;
            button3.GetComponent<Button>().interactable = false;
            button4.GetComponent<Button>().interactable = false;
            button5.GetComponent<Button>().interactable = false;
            button6.GetComponent<Button>().interactable = false;
        }
    }

    public void LoadScene1()
    {
        if (puzzlesResueltos == 0)
        {
            SceneManager.LoadScene("EscenaPrimerPuzzle");
            button1.GetComponent<Button>().interactable = false; //Desactivar button actual
            button1.gameObject.SetActive(false);
            button2.GetComponent<Button>().interactable = true;  //Activar siguiente button
            button2.gameObject.SetActive(true);
        }
    }

    public void LoadScene2()
    {
        if (puzzlesResueltos == 1)
        {
            SceneManager.LoadScene("EscenaSegundoPuzzle");
            button2.GetComponent<Button>().interactable = false;
            button2.gameObject.SetActive(false);
            button3.GetComponent<Button>().interactable = true;
            button3.gameObject.SetActive(true);
        }
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("EscenaTercerPuzzle");
        button3.GetComponent<Button>().interactable = false;
        button4.GetComponent<Button>().interactable = true;
    }

    public void LoadScene4()
    {
        SceneManager.LoadScene("EscenaCuartoPuzzle");
        button4.GetComponent<Button>().interactable = false;
        button5.GetComponent<Button>().interactable = true;
    }

    public void LoadScene5()
    {
        SceneManager.LoadScene("EscenaQuintoPuzzle");
        button5.GetComponent<Button>().interactable = false;
        button6.GetComponent<Button>().interactable = true;
    }

    public void LoadScene6()
    {
        SceneManager.LoadScene("EscenaSextoPuzzle");
        button6.GetComponent<Button>().interactable = false;
        button7.gameObject.SetActive(true);                     //Activar button7
        button7.GetComponent<Button>().interactable = true;
    }

    public void LoadScene7()
    {
        SceneManager.LoadScene("EscenaSeptimaPuzzle");
        
    }

    public void VolverAtras()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

}

﻿using System.Collections;
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
    public Transform button8;


    [HideInInspector]
    public static int puzzlesResueltos = 0;

    void Update()
    {

        if (puzzlesResueltos == 0){

            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            button4.gameObject.SetActive(false);
            button5.gameObject.SetActive(false);
            button6.gameObject.SetActive(false);
            button7.gameObject.SetActive(false);
            button8.gameObject.SetActive(false);

        }
        else if(puzzlesResueltos == 1){

            button1.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            button4.gameObject.SetActive(false);
            button5.gameObject.SetActive(false);
            button6.gameObject.SetActive(false);
            button7.gameObject.SetActive(false);
            button8.gameObject.SetActive(false);

        }
        else if (puzzlesResueltos == 2){

            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            button4.gameObject.SetActive(false);
            button5.gameObject.SetActive(false);
            button6.gameObject.SetActive(false);
            button7.gameObject.SetActive(false);
            button8.gameObject.SetActive(false);

        }
        else if (puzzlesResueltos == 3){

            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            button5.gameObject.SetActive(false);
            button6.gameObject.SetActive(false);
            button7.gameObject.SetActive(false);
            button8.gameObject.SetActive(false);

        }
        else if (puzzlesResueltos == 4){

            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            button4.gameObject.SetActive(false);
            button6.gameObject.SetActive(false);
            button7.gameObject.SetActive(false);
            button8.gameObject.SetActive(false);

        }
        else if (puzzlesResueltos == 5){

            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            button4.gameObject.SetActive(false);
            button5.gameObject.SetActive(false);
            button7.gameObject.SetActive(false);
            button8.gameObject.SetActive(false);

        }
        else if (puzzlesResueltos == 6){

            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            button4.gameObject.SetActive(false);
            button5.gameObject.SetActive(false);
            button6.gameObject.SetActive(false);
            button8.gameObject.SetActive(false);

        }
        else {

            button1.gameObject.SetActive(true);
            button2.gameObject.SetActive(true);
            button3.gameObject.SetActive(true);
            button4.gameObject.SetActive(true);
            button5.gameObject.SetActive(true);
            button6.gameObject.SetActive(true);
            button7.gameObject.SetActive(true);
            button8.gameObject.SetActive(true);

        }


    }

    public void LoadScene1()
    {
        if (puzzlesResueltos == 0)
        {
            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(true);
            if (MenuOpciones.esp)
                SceneManager.LoadScene("EscenaPrimerPuzzleEspañol");
            else
                SceneManager.LoadScene("EscenaPrimerPuzzle");
        }
        if (puzzlesResueltos >= 7)
        {
            if (MenuOpciones.esp)
                SceneManager.LoadScene("EscenaPrimerPuzzleEspañol");
            else
                SceneManager.LoadScene("EscenaPrimerPuzzle");
        }
    }

    public void LoadScene2()
    {
        if (puzzlesResueltos == 1)
        {
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(true);
            if (MenuOpciones.esp)
                SceneManager.LoadScene("EscenaSegundoPuzzleEspañol");
            else
                SceneManager.LoadScene("EscenaSegundoPuzzle");
        }
        if (puzzlesResueltos >= 7)
        {
            if (MenuOpciones.esp)
                SceneManager.LoadScene("EscenaSegundoPuzzleEspañol");
            else
                SceneManager.LoadScene("EscenaSegundoPuzzle");
        }
    }

    public void LoadScene3()
    {
        if (puzzlesResueltos == 2)
        {
            button3.gameObject.SetActive(false);
            button4.gameObject.SetActive(true);
            if (MenuOpciones.esp)
                SceneManager.LoadScene("EscenaTercerPuzzleEspañol");
            else
                SceneManager.LoadScene("EscenaTercerPuzzle");
        }
        if (puzzlesResueltos >= 7)
        {
            if (MenuOpciones.esp)
                SceneManager.LoadScene("EscenaTercerPuzzleEspañol");
            else
                SceneManager.LoadScene("EscenaTercerPuzzle");
        }

    }

    public void LoadScene4()
    {
        if (puzzlesResueltos == 3)
        {
            button4.gameObject.SetActive(false);
            button5.gameObject.SetActive(true);
            if (MenuOpciones.esp)
                SceneManager.LoadScene("EscenaCuartoPuzzleEspañol");
            else
                SceneManager.LoadScene("EscenaCuartoPuzzle");
        }
        if (puzzlesResueltos >= 7)
        {
            if (MenuOpciones.esp)
                SceneManager.LoadScene("EscenaCuartoPuzzleEspañol");
            else
                SceneManager.LoadScene("EscenaCuartoPuzzle");
        }
    }

    public void LoadScene5()
    {
        if (puzzlesResueltos == 4)
        {
            button5.gameObject.SetActive(false);
            button6.gameObject.SetActive(true);
            if (MenuOpciones.esp)
                SceneManager.LoadScene("EscenaQuintoPuzzleEspañol");
            else
                SceneManager.LoadScene("EscenaQuintoPuzzle");
        }
        if (puzzlesResueltos >= 7)
        {
            if (MenuOpciones.esp)
                SceneManager.LoadScene("EscenaQuintoPuzzleEspañol");
            else
                SceneManager.LoadScene("EscenaQuintoPuzzle");
        }
    }

    public void LoadScene6()
    {
        if(puzzlesResueltos == 5)
        {
            button6.gameObject.SetActive(false);
            button7.gameObject.SetActive(true); 
            if (MenuOpciones.esp)
                SceneManager.LoadScene("EscenaSextoPuzzleEspañol");
            else
                SceneManager.LoadScene("EscenaSextoPuzzle");
        }
        if (puzzlesResueltos >= 7)
        {
            if (MenuOpciones.esp)
                SceneManager.LoadScene("EscenaSextoPuzzleEspañol");
            else
                SceneManager.LoadScene("EscenaSextoPuzzle");
        }
    }

    public void LoadScene7()
    {
        if (puzzlesResueltos == 6)
        {
            button1.gameObject.SetActive(true);
            button2.gameObject.SetActive(true);
            button3.gameObject.SetActive(true);
            button4.gameObject.SetActive(true);
            button5.gameObject.SetActive(true);
            button6.gameObject.SetActive(true);
            button7.gameObject.SetActive(true);
            if (MenuOpciones.esp)
                SceneManager.LoadScene("EscenaSeptimaPuzzleEspañol");
            else
                SceneManager.LoadScene("EscenaSeptimaPuzzle");
        }
        if (puzzlesResueltos >= 7)
        {
            if (MenuOpciones.esp)
                SceneManager.LoadScene("EscenaSeptimaPuzzleEspañol");
            else
                SceneManager.LoadScene("EscenaSeptimaPuzzle");
        }
    }

    public void LoadScene8()
    {
        SceneManager.LoadScene("EscenaEasterEgg");
    }

    public void VolverAtras()
    {
        if (MenuOpciones.esp)
            SceneManager.LoadScene("MenuPrincipalEspañol");
        else
            SceneManager.LoadScene("MenuPrincipal");
    }

}

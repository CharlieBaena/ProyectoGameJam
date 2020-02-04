using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    Puzzle puzzle;

    private void Awake() {
        puzzle = GameObject.Find("Scripts").GetComponent(typeof(Puzzle)) as Puzzle;
    }

    public void BotonVolver() {
        if (MenuOpciones.esp)
            SceneManager.LoadScene("InterfazDePuzzleEspañol");
        else
            SceneManager.LoadScene("InterfazDePuzzle");
    }

    public void CambiarDificultad(bool valor) {
        puzzle.dificultadFacil = valor;
    }

}

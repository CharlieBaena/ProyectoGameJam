using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    Vector3 screenSpace, offset, posInicial;
    Sensores sensores;
    Puzzle puzzle;
    bool moviendoLeft, moviendoRight, moviendoUp, moviendoDown;
    UI ui;


    private void Awake(){
        sensores = GetComponentInChildren(typeof(Sensores)) as Sensores;
        puzzle = GameObject.Find("Scripts").GetComponent(typeof(Puzzle)) as Puzzle;
        ui = GameObject.Find("Scripts").GetComponent(typeof(UI)) as UI;
    }

    private void OnMouseDown(){
        Vector3 posVacia = transform.position;
        transform.position = puzzle.fichaEscondida.transform.position;
        puzzle.fichaEscondida.transform.position = posVacia;
    }

    private void OnMouseUp(){

        transform.position = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), 0);

        if (transform.position != posInicial)
        {
            ui.SumarMovimiento();
            puzzle.ComprobarGanador();
        }
        
        transform.position = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), 0);
        moviendoLeft = false;
        moviendoRight = false;
        moviendoUp = false;
        moviendoDown = false;
    }
}

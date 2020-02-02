using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    Vector3 posInicial;
    //Sensores sensores;
    Puzzle puzzle;
    //UI ui;
    bool puedoMover = false;


    private void Awake(){
        //sensores = GetComponentInChildren(typeof(Sensores)) as Sensores;
        puzzle = GameObject.Find("Scripts").GetComponent(typeof(Puzzle)) as Puzzle;
        //ui = GameObject.Find("Scripts").GetComponent(typeof(UI)) as UI;
    }

    private void OnMouseDown(){

        //Comprobar que esta la ficha vacia adyacente
        if (!puzzle.puzzleResuelto)
        {
            if (puzzle.dificultadFacil)
            {
                CambiarPosicion();
                puedoMover = true;
            }
            else
            {
                Vector3 posBase = new Vector3(transform.position.x, transform.position.y, 0);

                if ((puzzle.fichaEscondida.transform.position.x == posBase.x - 1) && (puzzle.fichaEscondida.transform.position.y == posBase.y))
                {
                    puedoMover = true;
                    CambiarPosicion();
                }
                if ((puzzle.fichaEscondida.transform.position.x == posBase.x + 1) && (puzzle.fichaEscondida.transform.position.y == posBase.y))
                {
                    puedoMover = true;
                    CambiarPosicion();
                }
                if ((puzzle.fichaEscondida.transform.position.x == posBase.x) && (puzzle.fichaEscondida.transform.position.y == posBase.y - 1))
                {
                    puedoMover = true;
                    CambiarPosicion();
                }
                if ((puzzle.fichaEscondida.transform.position.x == posBase.x) && (puzzle.fichaEscondida.transform.position.y == posBase.y + 1))
                {
                    puedoMover = true;
                    CambiarPosicion();
                }
            }
        }
       // Vector3 posVacia = transform.position;
        //transform.position = puzzle.fichaEscondida.transform.position;
        //puzzle.fichaEscondida.transform.position = posVacia;
    }

    private void OnMouseUp(){

        if (puedoMover)
        {
            transform.position = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), 0);

            if (transform.position != posInicial)
            {
                //ui.SumarMovimiento();
                puzzle.ComprobarGanador();
            }

            transform.position = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), 0);
            puedoMover = false;
        }
    }

    void CambiarPosicion()
    {
        Vector3 posVacia = transform.position;
        transform.position = puzzle.fichaEscondida.transform.position;
        puzzle.fichaEscondida.transform.position = posVacia;
    }
}

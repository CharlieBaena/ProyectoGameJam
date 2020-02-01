﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public List<Sprite> fichaImg = new List<Sprite>();  //lista donde almacenará los sprites cortados de cada ficha
    public GameObject fichaPrefab; //ficha basica de la cual se crearan el resto
    public GameObject bordePrefab; //borde basico del cual se crearan el resto
    public Sprite fichaEscondidaImg; //Para guarda imagen de la ficha que no se va a ver
    public GameObject textoGanador; //Texto cuando se complete el puzzle

    [HideInInspector]
<<<<<<< HEAD
    public bool dificultadFacil = true;
    [HideInInspector]
    public bool puzzleResuelto = false;
    [HideInInspector]

=======
>>>>>>> parent of 4de87e0... Merge branch 'master' of https://github.com/CharlieBaena/ProyectoGameJam
    public GameObject fichaEscondida; //objeto de la ficha escondida

    private int numCostado; //el numero de fichas por lado
    private GameObject padreFichas; //para organizar la escena
    private GameObject padreBordes; //para organizar la escena
    private List<Vector3> posicionesIniciales = new List<Vector3>(); //donde se almacenaran las posiciones iniciales, para comparar luego si se ha hecho bien
    private GameObject[] arrayFichas; //donde almacenaremos nuestras fichas




    private void Awake(){
        //buscamos los objetos que nos almacenaran las fichas y los bordes
        padreFichas = GameObject.Find("Fichas");
        padreBordes = GameObject.Find("Bordes");
        print(padreBordes.transform.position);
    }


    void Start(){
        if (Mathf.Sqrt (fichaImg.Count) == Mathf.Round (Mathf.Sqrt(fichaImg.Count))){ //Comprueba si el numero de fichas es cuadrado
            CrearFichas();
        } else {
            print("Imposible crear fichas");
        }
    }

    void CrearFichas(){
        int contador = 0;
        numCostado = (int)Mathf.Sqrt(fichaImg.Count);

        //Doble bucle para colocar todas las fichas en su sitio
        print("antes de entrar");
        for (int alto = numCostado + 2; alto > 0; alto--){
            for (int ancho = 0; ancho < numCostado + 2; ancho++){
                
                Vector3 posicion = new Vector3(ancho - (numCostado / 2), alto - (numCostado / 2), 0); //posicion de cada ficha
                print(posicion);
                //comprobar si son posiciones de borde o de fichas
                if (alto == 1 || alto == numCostado + 2 || ancho == 0 || ancho == numCostado +1) {  //creando el borde
                    
                    GameObject borde = Instantiate(bordePrefab, posicion, Quaternion.identity);     //instanciamos el borde
                    print("Antes de asignar al padre" + posicion);
                    borde.transform.parent = padreBordes.transform;                                 //lo ponemos como hijo de padreBordes
                    print("Despues de asignar al padre" + borde.transform.position);

                    print("borde creado");

                } else {                                                                            //creando las fichas del puzzle

                    GameObject ficha = Instantiate(fichaPrefab, posicion, Quaternion.identity);     //instanciamos la ficha
                    ficha.GetComponent<SpriteRenderer>().sprite = fichaImg[contador];               //asignamos el sprite de cada ficha
                    print("Antes de asignar al padre" + posicion);
                    ficha.transform.parent = padreFichas.transform;                                 //lo ponemos como hijo de padreFichas
                    print("Despues de asignar al padre" + ficha.transform.position);
                    ficha.name = fichaImg[contador].name;                                           //dejamos el mismo nombre que el sprite
                    if (ficha.name == fichaEscondidaImg.name)                                       //Si es la ficha que tenemos que esconder
                        fichaEscondida = ficha;                                                     //la asignamos
                    contador++;

                    print("ficha creado");

                }
            }
        }

        fichaEscondida.gameObject.SetActive(false);                                                 //escondemos la ficha escondida
                                                                                                    //a continuacion almacenamos las posiciones iniciales
        arrayFichas = GameObject.FindGameObjectsWithTag("Ficha");                                   //recuperamos todas las fichas con el tag ficha
        for (int i = 0; i < arrayFichas.Length; i++){
            posicionesIniciales.Add(arrayFichas[i].transform.position);                             //Asignamos las posiciones iniciales de las fichas
        }

        Barajar();

    }


    void Barajar(){
        int aleatorio;
        
        for (int i = 0; i < arrayFichas.Length; i++)
        {
            aleatorio = Random.Range(i, arrayFichas.Length);                                        //creamos un numero aleatorio entre i y el numero de fichas
            Vector3 posTemp = arrayFichas[i].transform.position;                                    //en una variable temporal guardamos la posicion inicial
            arrayFichas[i].transform.position = arrayFichas[aleatorio].transform.position;          //cambiamos la posicion de una ficha aleatoria a la posicion que hemos guardado
            arrayFichas[aleatorio].transform.position = posTemp;                                    //asignamos la posicion inical que habiamos guardado
        }
    }


    public void ComprobarGanador(){
        for(int i = 0; i < arrayFichas.Length; i++)
        {
            if (posicionesIniciales[i] != arrayFichas[i].transform.position)                        //repasamos las posiciones actuales y con que una ya no
                return;                                                                             //tenga la misma posicion que la inicial, salimos de la funcion
        }

        fichaEscondida.gameObject.SetActive(true);
        print("Puzzle resuelto!");
        textoGanador.gameObject.SetActive(true);
    }


    
}

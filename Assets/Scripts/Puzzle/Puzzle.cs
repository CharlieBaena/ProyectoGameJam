using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puzzle : MonoBehaviour
{
    public List<Sprite> fichaImg = new List<Sprite>();  //lista donde almacenará los sprites cortados de cada ficha
    public GameObject fichaPrefab; //ficha basica de la cual se crearan el resto
    public GameObject bordePrefab; //borde basico del cual se crearan el resto
    public Sprite fichaEscondidaImg; //Para guarda imagen de la ficha que no se va a ver
    public bool dificultadFacil = true;

    [HideInInspector]
    public bool puzzleResuelto = false;
    [HideInInspector]
    public GameObject fichaEscondida; //objeto de la ficha escondida
    [HideInInspector]
    public int numCostado; //el numero de fichas por lado
    private GameObject padreFichas; //para organizar la escena
    private GameObject padreBordes; //para organizar la escena
    private List<Vector3> posicionesIniciales = new List<Vector3>(); //donde se almacenaran las posiciones iniciales, para comparar luego si se ha hecho bien
    private GameObject[] arrayFichas; //donde almacenaremos nuestras fichas




    private void Awake() {
        //buscamos los objetos que nos almacenaran las fichas y los bordes
        padreFichas = GameObject.Find("Fichas");
        padreBordes = GameObject.Find("Bordes");    
    }


    void Start() {
        if (Mathf.Sqrt (fichaImg.Count) == Mathf.Round (Mathf.Sqrt(fichaImg.Count))){ //Comprueba si el numero de fichas es cuadrado
            CrearFichas();
        } else {
            print("Imposible crear fichas");
        }
    }

    void CrearFichas() {
        int contador = 0;
        numCostado = (int)Mathf.Sqrt(fichaImg.Count);

        //Doble bucle para colocar todas las fichas en su sitio
        for (int alto = numCostado + 2; alto > 0; alto--){
            for (int ancho = 0; ancho < numCostado + 2; ancho++){

                Vector3 posicion = new Vector3(ancho - (numCostado / 2), alto - (numCostado / 2), 0);// +offset; //posicion de cada ficha
               
                //comprobar si son posiciones de borde o de fichas
                if (alto == 1 || alto == numCostado + 2 || ancho == 0 || ancho == numCostado +1) {  //creando el borde
                    
                    GameObject borde = Instantiate(bordePrefab, posicion, Quaternion.identity);     //instanciamos el borde
                    borde.transform.parent = padreBordes.transform;       

                } else {                                                                            //creando las fichas del puzzle

                    GameObject ficha = Instantiate(fichaPrefab, posicion, Quaternion.identity);     //instanciamos la ficha
                    ficha.GetComponent<SpriteRenderer>().sprite = fichaImg[contador];               //asignamos el sprite de cada ficha
                    ficha.transform.parent = padreFichas.transform;                                 //lo ponemos como hijo de padreFichas
                    //print(contador.ToString() + ficha.transform.position);
                    ficha.name = fichaImg[contador].name;                                           //dejamos el mismo nombre que el sprite
                    if (ficha.name == fichaEscondidaImg.name)                                       //Si es la ficha que tenemos que esconder
                        fichaEscondida = ficha;                                                     //la asignamos
                    contador++;

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


    void Barajar() {
        int aleatorio;
        
        for (int i = 0; i < arrayFichas.Length; i++)
        {
            aleatorio = Random.Range(i, arrayFichas.Length);                                        //creamos un numero aleatorio entre i y el numero de fichas
            Vector3 posTemp = arrayFichas[i].transform.position;                                    //en una variable temporal guardamos la posicion inicial
            arrayFichas[i].transform.position = arrayFichas[aleatorio].transform.position;          //cambiamos la posicion de una ficha aleatoria a la posicion que hemos guardado
            arrayFichas[aleatorio].transform.position = posTemp;                                    //asignamos la posicion inical que habiamos guardado
        }
    }


    public void ComprobarGanador() {
        for(int i = 0; i < arrayFichas.Length; i++)
        {
            if (posicionesIniciales[i] != arrayFichas[i].transform.position)                        //repasamos las posiciones actuales y con que una ya no
                return;                                                                             //tenga la misma posicion que la inicial, salimos de la funcion
        }


        fichaEscondida.gameObject.SetActive(true);
       
        //print("Puzzle resuelto!");
        puzzleResuelto = true;
        StartCoroutine(CambiarEscena(10));
       

    IEnumerator CambiarEscena(float pauseTime) {
        Debug.Log("Inside PauseGame()");
        Time.timeScale = 0f;
        float pauseEndTime = Time.realtimeSinceStartup + pauseTime;
        while (Time.realtimeSinceStartup < pauseEndTime)
        {
            yield return 0;
        }
        Time.timeScale = 1f;
        Debug.Log("Done with my pause");
        SceneManager.LoadScene("InterfazDePuzzle");
        }
    }


}

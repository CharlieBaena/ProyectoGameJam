using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    public void BotonVolver()
    {
        SceneManager.LoadScene("InterfazDePuzzle");
    }
    /*Text numMovimientosTxt;
    int numMovimientos;*/

    /*private void Awake(){
        numMovimientosTxt = GameObject.Find("TextoMovimientos").GetComponent(typeof(Text)) as Text;
    }

    public void SumarMovimiento()
    {
        numMovimientos += 1;
        numMovimientosTxt.text = "Movimientos: " + numMovimientos.ToString();
    }*/
}

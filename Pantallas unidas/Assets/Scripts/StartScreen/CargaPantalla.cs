using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargaPantalla : MonoBehaviour {

	public void CargaEscena(string Escena)
    {
        //Application.LoadLevel(Escena);
        SceneManager.LoadScene(Escena);
    }
}

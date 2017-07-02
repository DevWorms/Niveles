using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargaPantalla : MonoBehaviour {

	public void CargaEscena(int Escena)
    {
        Application.LoadLevel(Escena);
    }
}

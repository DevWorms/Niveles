using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBehaviour : MonoBehaviour {

    public float speed = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        //Debug.Log( horz + " " + vert );
        
        // Linea para controlar ambos ejes
        //transform.position += (Vector3.up * vert + Vector3.right * horz) * speed * Time.deltaTime;

        // Linea para controlar solo el eje horizontal
        transform.position += (Vector3.right * horz) * speed * Time.deltaTime;

    }
}

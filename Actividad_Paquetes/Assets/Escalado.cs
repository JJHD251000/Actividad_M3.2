using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalado : MonoBehaviour
{
    GameObject esfera;
    private Vector3 cambio;
    bool bandera = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void escaladoEsfera() {
        esfera = GameObject.Find("Sphere");

        if(esfera.transform.localScale.x < 1) {
            bandera = false;
        } 

        if(esfera.transform.localScale.x > 3) {
            bandera = true;
        }

        if (bandera) {
            cambio = new Vector3(-0.01f, -0.01f, -0.01f);
        }
        else {
            cambio = new Vector3(0.01f, 0.01f, 0.01f);
        }
        esfera.transform.localScale += cambio;
    }
    
    // Update is called once per frame
    void Update()
    {
       escaladoEsfera(); 
    }
}

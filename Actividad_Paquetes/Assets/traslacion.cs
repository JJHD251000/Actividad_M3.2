using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traslacion : MonoBehaviour
{
    GameObject capsula;
    private Vector3 cambio;
    bool bandera = false;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    void posicionCapusla() {
        capsula = GameObject.Find("Capsule");
        
        if(capsula.transform.localPosition.x < 1){
            bandera = false;
        }
        if(capsula.transform.localPosition.x > 3){
            bandera = true;
        }
        if(bandera){
            cambio = new Vector3(-0.01f, -0.01f, -0.01f);
        }
        else {
            cambio = new Vector3(0.01f, 0.01f, 0.01f);
        }

        capsula.transform.localPosition += cambio;
    }

    // Update is called once per frame
    void Update()
    {
       posicionCapusla(); 
    }
}

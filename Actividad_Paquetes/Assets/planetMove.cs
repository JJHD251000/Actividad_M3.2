﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      GameObject.Find("Sun").transform.Rotate(Vector3.up * Time.deltaTime * 5 );

      GameObject.Find("Mercury").transform.RotateAround(Vector3.zero, new Vector3(0.1f, 1, 0), 60 * Time.deltaTime);
                 // Establecer la dirección y velocidad de revolución El eje de dirección es (0， 1， 0) La velocidad es 60
      GameObject.Find("Mercury").transform.Rotate(Vector3.up * Time.deltaTime * 10000 / 58);
                 // Establezca la velocidad de rotación como10000/58   58Es el ciclo autobiográfico de Mercury, el recíproco es el tiempo, lo mismo a continuación

      GameObject.Find("Venus").transform.RotateAround(Vector3.zero, new Vector3(0, 1, -0.1f), 55 * Time.deltaTime);
      GameObject.Find("Venus").transform.Rotate(Vector3.up * Time.deltaTime * 10000 / 243);

      GameObject.Find("Earth").transform.RotateAround(Vector3.zero, new Vector3(0, 1, 0), 50 * Time.deltaTime);
      GameObject.Find("Earth").transform.Rotate(Vector3.up * Time.deltaTime * 10000);

      GameObject.Find("Mars").transform.RotateAround(Vector3.zero, new Vector3(0.2f, 1, 0), 45 * Time.deltaTime);
      GameObject.Find("Mars").transform.Rotate(Vector3.up * Time.deltaTime * 10000);

      GameObject.Find("Jupiter").transform.RotateAround(Vector3.zero, new Vector3(-0.1f, 2, 0), 35 * Time.deltaTime);
      GameObject.Find("Jupiter").transform.Rotate(Vector3.up * Time.deltaTime * 10000 / 0.3f);

      GameObject.Find("Saturn").transform.RotateAround(Vector3.zero, new Vector3(0, 1, 0.2f), 20 * Time.deltaTime);
      GameObject.Find("Saturn").transform.Rotate(Vector3.up * Time.deltaTime * 10000 / 0.4f);

      GameObject.Find("Uranus").transform.RotateAround(Vector3.zero, new Vector3(0, 2, 0.1f), 15 * Time.deltaTime);
      GameObject.Find("Uranus").transform.Rotate(Vector3.up * Time.deltaTime * 10000 / 0.6f);

      GameObject.Find("Neptune").transform.RotateAround(Vector3.zero, new Vector3(-0.1f, 1, -0.1f), 10 * Time.deltaTime);
      GameObject.Find("Neptune").transform.Rotate(Vector3.up * Time.deltaTime * 10000 / 0.7f);  
    }
}

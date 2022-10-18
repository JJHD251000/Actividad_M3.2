using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    GameObject cubo;
    float x;
    float y;
    float z;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void rotacionCubo() {
        x += 10 * Time.deltaTime;
        y += 10 * Time.deltaTime;
        z += 10 * Time.deltaTime;
        cubo = GameObject.Find("Cube");
        cubo.transform.localRotation = Quaternion.Euler(x,y,z);
    }
    
    // Update is called once per frame
    void Update()
    {
       rotacionCubo(); 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteract : MonoBehaviour
{
    public Inventary inventary;
    // Start is called before the first frame update
    void Start()
    {
        inventary = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventary>();   
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") {
            inventary.Cantidad = inventary.Cantidad + 1;
            Destroy(gameObject);
        }   
    }
}

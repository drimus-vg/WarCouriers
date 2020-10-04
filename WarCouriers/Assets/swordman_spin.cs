using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordman_spin : MonoBehaviour
{
    public Vector3 spin;
    public Rigidbody swordmanRB;
    bool entertrigger;


    private void Start()
    {
        entertrigger = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            entertrigger = true;
        }   
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            entertrigger = false;
        }
    }


    void Update()
    {
        if (entertrigger)
            swordmanRB.AddTorque(spin);
        else swordmanRB.AddTorque(Vector3.zero);
    }
}
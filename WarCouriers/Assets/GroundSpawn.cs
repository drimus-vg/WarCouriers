using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    public GameObject ground;
    public Transform groundSpawnPoint;

    private bool despawn;

    void Start()
    {
        despawn = false;
        ground = GroundDetector.
    }

    void Update()
    {
        if (despawn)
        {
            BeginDespawn();
        }
    }

    void BeginDespawn()
    {
        Instantiate(ground, groundSpawnPoint.position, groundSpawnPoint.rotation);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GroundSpawner")
        {
            Debug.Log("estoy entrando acá");
            despawn = true;
        }
    }

}

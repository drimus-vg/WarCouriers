using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    public GameObject ground;
    public Transform groundSpawnPoint;
    GameObject groundSpawner;

    private bool despawn;

    void Start()
    {
        despawn = false;
        groundSpawner = GameObject.Find("GroundSpawner");
        GroundDetector gd = groundSpawner.GetComponent<GroundDetector>();
        ground = gd.ground;
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

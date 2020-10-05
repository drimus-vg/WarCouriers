using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    public GameObject player;
    public GameObject ground;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = player.transform.position;
    }
}

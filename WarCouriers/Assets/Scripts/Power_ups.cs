using UnityEngine;

public class Power_ups : MonoBehaviour
{


    public PlayerStatus PS;
    public Rigidbody triggerbody;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Player")
        {
            PS.godmode = true;
            Destroy(triggerbody.gameObject);
        }

    }

}
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public Rigidbody triggerbody;
    public WorldEvents Event;

    
    void Update()
    {
        triggerbody.AddTorque(Vector3.up * 50);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (triggerbody.tag == "godmode")
            {
                Event.OnGodMode();
            }

            if (triggerbody.tag == "slowmode")
            {
                Event.OnSlowMode();
            }
            //Destroy(triggerbody.gameObject);
        }
    }
}
using UnityEngine;

public class PowerUps : MonoBehaviour
{


    public PlayerStatus PS;
    public Rigidbody triggerbody;
    public PlayerStatus slowmode;


    void Update()
    {
        Time.timeScale += (1f / slowmode.duration) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
        triggerbody.AddTorque(Vector3.up * 50);
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            if (triggerbody.tag == "godmode")
            {

                PS.godmode = true;

            }

            if (triggerbody.tag == "slowmode")
            {
                Time.timeScale = slowmode.factor;
                Time.fixedDeltaTime = Time.timeScale * .02f;
                Debug.Log("hola");
            }
            Destroy(triggerbody.gameObject);
        }
    }
}
using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour
{
    public bool godmode;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        godmode = false;
    }

    private void Update()
    {
        if (godmode)
        {
            StartCoroutine(godmode_on());
            Debug.Log("coroutine start");
        }
    }



    IEnumerator godmode_on()
    {
        rb.mass = 2000;
        yield return new WaitForSecondsRealtime(3);
        godmode = false;
    }


}

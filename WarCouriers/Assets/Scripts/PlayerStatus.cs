using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour
{
    public bool godmode;
    public Rigidbody rb;
    public float godmodeDuration;

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
        rb.mass = 10000;
        yield return new WaitForSecondsRealtime(godmodeDuration);
        godmode = false;
    }
}

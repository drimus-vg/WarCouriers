using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldEvents : MonoBehaviour
{
    public float slowmodeFactor = 0.05f;
    public float slowmodeDuration = 2f;
    public float godmodeDuration = 2f;
    public bool godmode;


    public void OnSlowMode()
    {
        Time.timeScale = slowmodeFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
        ResetTime();
    }

    void ResetTime()
    {
        if (Time.timeScale < 1)
        {
            Time.timeScale += (1f / slowmodeDuration) * Time.unscaledDeltaTime;
            Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
            Invoke("ResetTime", 1f * Time.unscaledDeltaTime);
            Debug.Log(Time.timeScale);
        }
        else
        {
            Time.fixedDeltaTime = 0.02f;
            Debug.Log(Time.timeScale);
            Debug.Log(Time.fixedDeltaTime);
        }
    }


    public void OnGodMode()
    {
        godmode = true;
        Debug.Log("godmode"+godmode);
        //Invoke("GodModeOff", 10f);
    }

    private void GodModeOff()
    {
        godmode = false;
        Debug.Log("xd" + godmode);
    }
}

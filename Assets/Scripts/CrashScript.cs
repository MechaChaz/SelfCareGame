using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashScript : MonoBehaviour
{
    bool gohome = false;
    [SerializeField] SceneLoader scene = null;

    public void CrashReady()
    {
        gohome = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" && gohome == true)
        {
            scene.NextScene();
        }
    }
    bool Ready()
    {
        return gohome;
    }
}

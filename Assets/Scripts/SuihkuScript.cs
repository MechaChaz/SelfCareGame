using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuihkuScript : MonoBehaviour
{
    float time = 0;
    [SerializeField] StateManager manager = null;
    int sceneIndex;
    [SerializeField] Vector2 force = Vector2.up;
    [SerializeField] PlayerScript player = null;

    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            time += 1 * Time.deltaTime;
            if (time > 5)
            {
                manager.SetShower();
            }
        }
        if (player.Cheat() == false && other.tag == "Player" && (sceneIndex == 4 || sceneIndex == 7))
        {
            other.attachedRigidbody.AddForce(force);
        }
    }

    void OnTriggerExit2D(Collider2D co)
    {
        time = 0;
    }


    /*void OnTriggerStay2D(Collider2D col)
    {
        if(sceneIndex == 2 && col.tag == "Player")
        {
            //GetComponent<Collider2D>().attachedRigidbody.AddForce(force);
            col.attachedRigidbody.AddForce(force);
        }
    }*/
}

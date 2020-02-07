using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemScript : MonoBehaviour
{
    [SerializeField] TextScript item = null;
    [SerializeField] StateManager manager = null;
    int sceneIndex = 0;
    [SerializeField] FlyingItem itemf = null;

    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && (sceneIndex == 1 || sceneIndex == 4 || sceneIndex == 10))
        {
            item.Succes();
            gameObject.SetActive(false);
            manager.Shopping();
        }
        if (collision.tag == "Player" && (sceneIndex == 7))
        {
            gameObject.SetActive(false);
            itemf.Fly();
        }
    }
}

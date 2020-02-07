using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingItem : MonoBehaviour
{
    [SerializeField] TextScript item = null;
    [SerializeField] StateManager manager = null;
    [SerializeField] Vector2 force = Vector2.up;
    Rigidbody2D esine;

    void Start()
    {
        gameObject.SetActive(false);
        esine = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            item.Succes();
            gameObject.SetActive(false);
            manager.Shopping();
        }
    }
    public void Fly()
    {
        gameObject.SetActive(true);
        esine.AddForce(force);
    }
}

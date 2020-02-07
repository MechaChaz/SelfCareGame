using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SontsaScript : MonoBehaviour
{
    [SerializeField] PlayerScript player = null;
    SpriteRenderer render;
    public Sprite empty;

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            render.sprite = empty;
            player.Umbrella();
        }
    }
}

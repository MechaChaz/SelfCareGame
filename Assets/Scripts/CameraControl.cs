using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] GameObject pelaaja = null;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //koti
        if (pelaaja.transform.position.x > -6.18f)
        {
            transform.position = new Vector3( 0, 0, -10);
        }

        //katu
        if (pelaaja.transform.position.x < -6.18f)
        {
            transform.position = new Vector3(-12.61f, 0, -10);
        }
        //kauppa
        if (pelaaja.transform.position.x < -18.9f)
        {
            transform.position = new Vector3(-25.1f, 0, -10);
        }
    }
}

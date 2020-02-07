using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeLol : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void Animate()
    {
        gameObject.SetActive(true);
    }

}

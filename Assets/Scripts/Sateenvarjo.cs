using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sateenvarjo : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);       
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }
}

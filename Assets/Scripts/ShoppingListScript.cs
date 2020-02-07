using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingListScript : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void ShowItem()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}

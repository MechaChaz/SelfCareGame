using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{

    [SerializeField] Text text = null;
    
    public void Succes()
    {
        text.color = Color.green;
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

}

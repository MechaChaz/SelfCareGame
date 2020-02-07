using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    bool umbrella = false;
    [SerializeField] Sateenvarjo varjo = null;

    public void Umbrella()
    {
        umbrella = true;
        varjo.Show();
    }
    public bool Cheat()
    {
        return umbrella;
    }
}

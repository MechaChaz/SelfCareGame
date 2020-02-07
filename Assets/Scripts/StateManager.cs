using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    bool suihku = false;
    bool ruoka = false;
    float time = 0;
    int satisfaction = 0;
    int shopping = 0;
    [SerializeField] DoorScript door = null;
    [SerializeField] TextScript shower = null;
    [SerializeField] TextScript food = null;
    [SerializeField] ShoppingListScript sausage = null;
    [SerializeField] ShoppingListScript salad = null;
    [SerializeField] ShoppingListScript beer = null;
    [SerializeField] ShoppingListScript goHome = null;
    [SerializeField] CrashScript crash = null;
    [SerializeField] AnimeLol anime = null;


    public void SetShower()
    {
        suihku = true;
        shower.Succes();
    }
    public void SetFood()
    {
        ruoka = true;
        food.Succes();
    }
    public void Satisfaction()
    {
        satisfaction++;
    }
    public void Shopping()
    {
        shopping++;
    }
    
    void Update()
    {
        if (suihku == true && ruoka == true)
        {
            time += 1 * Time.deltaTime;
            if (time > 2)
            {
                shower.Hide();
                food.Hide();
                sausage.ShowItem();
                salad.ShowItem();
                beer.ShowItem();
                door.OpenDoor();
                suihku = false;
                time = 0;
            }
        }
        if (satisfaction >= 3)
        {
            SetFood();
        }
        if(shopping >= 3)
        {
            time += 1 * Time.deltaTime;
            Debug.Log(time);
            if (time > 1)
            {
                sausage.Hide();
                salad.Hide();
                beer.Hide();
                goHome.ShowItem();
                crash.CrashReady();
                anime.Animate();
                shopping = 0;
            }
        }
    }
}



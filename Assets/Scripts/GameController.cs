using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    public int currentPlayer;
    public GameObject fly;
    public GameObject tiger;
   
    void Start()
    {
        currentPlayer = 0;
        fly.SetActive(false);
        tiger.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            FlyTurn();
            fly.GetComponent<MoveByTouch>().enabled = true;
            tiger.GetComponent<MoveByTouch>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            TigerTurn();
           tiger.GetComponent<MoveByTouch>().enabled = true;
            fly.GetComponent<MoveByTouch>().enabled = false;

        }

    }

    
    void FlyTurn()
    {
        if (currentPlayer == 0)
        {
            fly.SetActive(true);
            currentPlayer = 1;
        }

    }
    void TigerTurn()
    {
        if (currentPlayer == 1)
        {
            tiger.SetActive(true);

            currentPlayer = 0;

        }
    }

    


}

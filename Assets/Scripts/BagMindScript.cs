using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagMindScript : MonoBehaviour
{
    public GameObject[] Players;
    [SerializeField]
    GameObject CurrentPlayer;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < Players.Length; i++)
        {
            Players[i].GetComponent<MoveByTouch>().enabled = false;

        }
        CurrentPlayer = Players[0];

    }

    public void ChangePlayer(GameObject player)
    {
        CurrentPlayer.GetComponent<MoveByTouch>().enabled = false;
        CurrentPlayer = player;

    }
}

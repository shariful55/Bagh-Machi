using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
     /* blue
      * red
      * green
      * black
      * */
    public GameObject Player;
    private int _next=4;
    
    private void Start()
    {

        
    }

   private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _next = 0;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            _next = 1;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            _next = 2;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            _next = 4;
        }

        switch (_next)
        {
            case 0:
                Player.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 1:
                Player.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                Player.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 3:
                Player.GetComponent<Renderer>().material.color = Color.gray;
                break;
            case 4:
                Player.GetComponent<Renderer>().material.color = Color.black;
                break;
            default:
                Debug.Log("Invalid Color");
                break;
        }
    }
}

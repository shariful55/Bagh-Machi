using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerScript : MonoBehaviour
{

    // public GameObject[] players;
    public GameObject players;
    public int count;
    public int Total = 0;
    // public GameObject prefab;


    // Start is called before the first frame update
    void Start()
    {
        players.SetActive(false);

        //for (int i = 0; i < players.Length; i++)
        //{
        //    players[i].SetActive(false);
        //}




    }

    // Update is called once per frame
    void Update()
    {


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);


            if (Total < 4)
            {
                if (touch.phase == TouchPhase.Began)
                {

                    // quater 1
                    // center .
                    if (touchPosition.x > -0.5f && touchPosition.x < 0.5f && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                    {
                        if (players.activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        Instantiate(players, players.transform.position, Quaternion.identity);
                        players.SetActive(true);
                        players.transform.position = new Vector3(0, 0, 0);
                        TochActivate tochscript = GetComponent<TochActivate>();
                        tochscript.GetComponent<TochActivate>().enabled = false;
                        MindScript mind = GetComponent<MindScript>();
                        mind.GetComponent<MindScript>().enabled = false;




                    }

                    if (touchPosition.x > 1.25f && touchPosition.x < 1.75 && touchPosition.y > -0.5f && touchPosition.y < 0.5f)
                    {
                        if (players.activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        Instantiate(players, players.transform.position, Quaternion.identity);
                        players.SetActive(true);
                        players.transform.position = new Vector3(1.5f, 0, 0);
                        GetComponent<TochActivate>().enabled = false;
                        GetComponent<MindScript>().enabled = false;

                    }
                    // left--
                    else if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > -0.1f && touchPosition.y < 0.1f)
                    {
                        if (players.activeSelf == false && Input.touchCount == 1)
                        {
                            count = 1;
                            Total = Total + count;
                        }
                        Instantiate(players, players.transform.position, Quaternion.identity);
                        players.SetActive(true);
                        players.transform.position = new Vector3(3, 0, 0);
                        GetComponent<TochActivate>().enabled = false;
                        GetComponent<MindScript>().enabled = false;

                       }
            //        // up-
            //        if (touchPosition.x > -0.1f && touchPosition.x < 0.1f && touchPosition.y > 1.25 && touchPosition.y < 1.75)
            //        {
            //            if (players[3].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[3].SetActive(true);
            //            players[3].transform.position = new Vector3(0, 1.5f, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }
            //        //up--
            //        if (touchPosition.x > -0.1f && touchPosition.x < 0.1f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
            //        {
            //            if (players[0].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[0].SetActive(true);
            //            players[0].transform.position = new Vector3(0, 3, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }
            //        else if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > 1.25 && touchPosition.y < 1.75)
            //        {
            //            if (players[1].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[1].SetActive(true);
            //            players[1].transform.position = new Vector3(1.5f, 1.5f, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }

            //        else if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
            //        {
            //            if (players[2].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[2].SetActive(true);
            //            players[2].transform.position = new Vector3(1.5f, 3, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }
            //        else if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > 2.75 && touchPosition.y < 3.25)
            //        {
            //            if (players[3].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[3].SetActive(true);
            //            players[3].transform.position = new Vector3(3, 3, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }

            //        else if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
            //        {
            //            if (players[0].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[0].SetActive(true);
            //            players[0].transform.position = new Vector3(3, 1.5f, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }
            //        // quater 2
            //        //down-
            //        else if (touchPosition.x > -0.1f && touchPosition.x < 0.1f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
            //        {
            //            if (players[1].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[1].SetActive(true);
            //            players[1].transform.position = new Vector3(0, -1.5f, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }
            //        // down--
            //        else if (touchPosition.x > -0.1f && touchPosition.x < 0.1f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
            //        {
            //            if (players[2].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[2].SetActive(true);
            //            players[2].transform.position = new Vector3(0, -3, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }
            //        // down left cross-
            //        else if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -1.75 && touchPosition.y < -1.25)
            //        {
            //            if (players[3].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[3].SetActive(true);
            //            players[3].transform.position = new Vector3(1.5f, -1.5f, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;

            //        }
            //        //down left
            //        else if (touchPosition.x > 1.25f && touchPosition.x < 1.75f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
            //        {
            //            if (players[0].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[0].SetActive(true);
            //            players[0].transform.position = new Vector3(1.5f, -3, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }
            //        // down left corner
            //        else if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
            //        {
            //            if (players[1].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[1].SetActive(true);
            //            players[1].transform.position = new Vector3(3, -3, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }
            //        // down p left
            //        else if (touchPosition.x > 2.75f && touchPosition.x < 3.25f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
            //        {
            //            if (players[2].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[2].SetActive(true);
            //            players[2].transform.position = new Vector3(3, -1.5f, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }
            //        // quater 3
            //        //right-
            //        else if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -0.1f && touchPosition.y < 0.1f)
            //        {
            //            if (players[3].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[3].SetActive(true);
            //            players[3].transform.position = new Vector3(-1.5f, 0, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }

            //        // right--
            //        else if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > -0.1f && touchPosition.y < 0.1f)
            //        {
            //            if (players[0].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[0].SetActive(true);
            //            players[0].transform.position = new Vector3(-3, 0, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }
            //        // down right cross
            //        else if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
            //        {
            //            if (players[1].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[1].SetActive(true);
            //            players[1].transform.position = new Vector3(-1.5f, -1.5f, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }

            //        //down right-
            //        else if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
            //        {
            //            if (players[2].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[2].SetActive(true);
            //            players[2].transform.position = new Vector3(-1.5f, -3, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }

            //        // rightdown
            //        else if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > -1.75f && touchPosition.y < -1.25f)
            //        {
            //            if (players[3].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[3].SetActive(true);
            //            players[3].transform.position = new Vector3(-3, -1.5f, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }
            //        // down right cross
            //        else if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > -3.25f && touchPosition.y < -2.75f)
            //        {
            //            if (players[0].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[0].SetActive(true);
            //            players[0].transform.position = new Vector3(-3, -3, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }
            //        // quater 4
            //        // up righ cross
            //        else if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
            //        {
            //            if (players[1].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[1].SetActive(true);
            //            players[1].transform.position = new Vector3(-1.5f, 1.5f, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }

            //        //up right-
            //        else if (touchPosition.x > -1.75f && touchPosition.x < -1.25f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
            //        {
            //            if (players[2].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[2].SetActive(true);
            //            players[2].transform.position = new Vector3(-1.5f, 3, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }

            //        // up p right
            //        else if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > 1.25f && touchPosition.y < 1.75f)
            //        {
            //            if (players[3].activeSelf == false && Input.touchCount == 1)
            //            {

            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[3].SetActive(true);
            //            players[3].transform.position = new Vector3(-3, 1.5f, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }
            //        // up right corner
            //        else if (touchPosition.x > -3.25f && touchPosition.x < -2.75f && touchPosition.y > 2.75f && touchPosition.y < 3.25f)
            //        {
            //            if (players[0].activeSelf == false && Input.touchCount == 1)
            //            {
            //                count = 1;
            //                Total = Total + count;
            //            }
            //            players[0].SetActive(true);
            //            players[0].transform.position = new Vector3(-3, 3, 0);
            //            GetComponent<TochActivate>().enabled = false;
            //            GetComponent<MindScript>().enabled = false;
            //        }
            //    }

            //}

            else
            {
                            GetComponent<TigerScript>().enabled = false;
                            //GetComponent<TochActivate>().enabled = true;
                            // GetComponent<MindScript>().enabled = true;
                        }


                    }
                }


            }
        }
    }

